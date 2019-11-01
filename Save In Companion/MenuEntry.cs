using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;


namespace Save_In_Companion
{
    /// <summary>
    /// Class containing methods to retrieve specific file system paths.
    /// </summary>
    public class MenuEntry
    {
        public string FolderPath { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }

        public List<MenuEntry> SubEntries { get; set; }

        public int Deepness { get; set; }

        public bool IsSeperator { get; set; }

        public bool IsCategory { get; set; }

        public MenuEntry()
        {
            SubEntries = new List<MenuEntry>();
        }

        string GetRootFolder(string path)
        {
            string rootFolder;
             
            //HACK: I don't know of a good way of handling the root of a linux volume.
            if (string.IsNullOrEmpty(path))
            {
                rootFolder = "SaveInRoot";
            }
            else
            {
                rootFolder = path;

                while (true)
                {
                    string temp = Path.GetDirectoryName(path);
                    if (String.IsNullOrEmpty(temp))
                        break;
                    path = temp;
                } 
            }
            return rootFolder;
        }

        public void BuildOutput(StringWriter stream, Settings settings)
        {
            if (IsSeperator)
            {
                stream.WriteLine("---");
            }
            else if (IsCategory)
            {
                if (SubEntries.Count > 0)
                {
                    stream.WriteLine(string.Format(". // (alias:{0})", Name));
                    SubEntries.ForEach(x => x.BuildOutput(stream, settings));
                }
            }
            else
            {
                string finalPath;

                if (FolderPath.StartsWith(settings.DownloadsFolderPath))
                {
                    if (FolderPath == settings.DownloadsFolderPath)
                    {
                        finalPath = string.Format(". //{0} (alias: {1})", Comment, Name);
                    }
                    else
                    {
                        finalPath = FolderPath.Remove(0, settings.DownloadsFolderPath.Length + 1);
                    }
                }
                else
                {
                    // Get the drive prefix.
                    string drivePrefix = Path.GetPathRoot(FolderPath);

                    // Get the folder path with the drive prefix removed
                    string relativePath = FolderPath.Remove(0, drivePrefix.Length);

                    // Get the safe identifier of the drive
                    char[] arr = drivePrefix.ToCharArray();
                    arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c)
                                                      || char.IsWhiteSpace(c)
                                                      || c == '-')));
                    string driveLetter = new string(arr);

                    // Get the root folder of the relative path.
                    string rootFolder = GetRootFolder(relativePath);

                    // create final written path
                    finalPath = string.Format("{0}{1} //{2} (alias:{3})", new string('>', Deepness),
                        Path.Combine(settings.SaveInLinksFolderName, driveLetter + relativePath), Comment, Name);

                    if (!settings.SkipLinkCreation)
                    {
                        // Create a link path.
                        string link = Path.Combine(settings.SaveInLinksFolderPath, driveLetter + rootFolder);

                        if (!Directory.Exists(link))
                        {
                            string realPath;

                            // Get real path folder
                            //HACK:
                            if (rootFolder == "SaveInRoot")
                            {
                                realPath = "/";
                            }
                            else
                            {
                                realPath = Path.Combine(drivePrefix, rootFolder);

                            }
                            CreateSymbolicLink(link, realPath);
                        }
                    }
                }

                // Write the final path
                stream.WriteLine(finalPath);

                // Do all of this for each sub entry and so on.
                SubEntries.ForEach(x => x.BuildOutput(stream, settings));
            }
        }

        private void CreateSymbolicLink(string linkPath, string realPath)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;

            if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                startInfo.FileName = "ln";

                startInfo.Arguments = string.Format("-s {0} {1}", realPath, linkPath);
            }
            else
            {
                startInfo.FileName = "cmd.exe";

                string linktype;
                if (IsUserAnAdmin()) linktype = "D";
                else linktype = "J";

                startInfo.Arguments = string.Format("/C mklink /{0} {1} {2}", linktype, linkPath, realPath);
            }

            process.StartInfo = startInfo;

            process.Start();

            // Wait for finish, else this will get called several times in a tight loop 
            process.WaitForExit();
        }


        [DllImport("shell32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsUserAnAdmin();

        public void LoadSubdirectories(Settings settings)
        {
            if (FolderPath == settings.SaveInLinksFolderPath || FolderPath == null || FolderPath == string.Empty)
            {
                return;
            }

            try
            {
                string[] subdirectoryEntries = Directory.GetDirectories(FolderPath);

                if (subdirectoryEntries.Length > 0)
                {
                    for (int i = 0; i < subdirectoryEntries.Length; i++)
                    {
                        SubEntries.Add(new MenuEntry() { FolderPath = subdirectoryEntries[i], Name = Path.GetFileName(subdirectoryEntries[i]), Deepness = this.Deepness + 1 });
                        SubEntries[i].LoadSubdirectories(settings);
                    }

                    if (!settings.DisableLinkBack)
                    {
                        string insertName = settings.BackLinkStartText + this.Name + settings.BackLinkEndText;


                        if (settings.IncludeNameInBackLink)
                            insertName = settings.BackLinkStartText + this.Name + settings.BackLinkEndText;
                        else
                            insertName = settings.BackLinkStartText + settings.BackLinkEndText;

                        MenuEntry entry = new MenuEntry() { FolderPath = this.FolderPath, Name = insertName, Deepness = this.Deepness + 1 };

                        if (settings.LinkBackOnBottom)
                            SubEntries.Add(entry);
                        else
                            SubEntries.Insert(0, entry);
                    }
                }
                else if (!settings.DisableLinkBack && settings.ForceLinkBack && Deepness > 0)
                {
                    string insertName = settings.BackLinkStartText + this.Name + settings.BackLinkEndText;


                    if (settings.IncludeNameInBackLink)
                        insertName = settings.BackLinkStartText + this.Name + settings.BackLinkEndText;
                    else
                        insertName = settings.BackLinkStartText + settings.BackLinkEndText;

                    MenuEntry entry = new MenuEntry() { FolderPath = this.FolderPath, Name = insertName, Deepness = this.Deepness + 1 };


                    SubEntries.Add(entry);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
            catch (DirectoryNotFoundException) // Probably a broken link within the path, in this context..
            {
                return;
            }
            //TODO: Should probably give some feedback.
            catch (PathTooLongException)
            {
                return;
            }
            
        }

        public override string ToString()
        {
            if (IsSeperator)
            {
                return "###Seperator###";
            }
            else if (IsCategory)
            {
                return string.Format("Category: {0}", Name);
            }
            else
            {
                if (Comment != string.Empty && Comment != null)
                {
                    return string.Format("{0} (Name: {1}) (Comment: {2})", FolderPath, Name, Comment);
                }
                else
                {
                    return string.Format("{0} (Name: {1})", FolderPath, Name);
                }
            }
        }
    }
}