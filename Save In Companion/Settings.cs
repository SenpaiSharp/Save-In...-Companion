using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Save_In_Companion
{
    public enum AutoExpandOption
    {
        Disabled,
        OneLevel,
        All
    }

    public class Settings
    {
        public List<MenuEntry> MenuEntries { get; set; } = new List<MenuEntry>();

        public string DownloadsFolderPath { get; set; }

        public string SaveInLinksFolderName { get; set; }

        public string SaveInLinksFolderPath { get { return Path.Combine(DownloadsFolderPath, SaveInLinksFolderName); } }

        public bool HideSaveInFolderInWindows { get; set; } = true;

        public bool MarkSaveInFolderAsSystemInWindows { get; set; } = true;

        public bool SkipLinkCreation { get; set; }

        public AutoExpandOption AutoExpandOption { get; set; } = AutoExpandOption.OneLevel;

        public string BackLinkStartText { get; set; } = "*";

        public string BackLinkEndText { get; set; } = string.Empty;

        public bool IncludeNameInBackLink { get; set; } = true;

        public bool LinkBackOnBottom { get; set; }

        public bool ForceLinkBack { get; set; }

        public bool DisableLinkBack { get; set; }

        public bool FirstTimeRun { get; set; } = true;

        private Settings()
        {
            DownloadsFolderPath = GetDefaultDownloadsFolder();
            if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                SaveInLinksFolderName = ".SaveInLinks";
            }
            else
            {
                SaveInLinksFolderName = "SaveInLinks";
            }
        }

        public void SaveSettings()
        {
            string settingsPath = GetSettingsPath();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

            using (FileStream fs = new FileStream(settingsPath, FileMode.Create))
            {
                using (DeflateStream ds = new DeflateStream(fs, CompressionLevel.Optimal))
                {
                    xmlSerializer.Serialize(ds, this);
                }
            }
        }

        public static string GetSettingsPath()
        {
            
            string executableFolder = Path.GetDirectoryName(Application.ExecutablePath); 
            return Path.Combine(executableFolder, "settings.sic");
        }

        /// <summary>
        /// Gets the assumed download folder location.
        /// </summary>
        /// <returns>Path to alleged download folder.</returns>
        public string GetDefaultDownloadsFolder()
        {
            //HACK: No warranties result
            /* I am aware that this simplistic method will NOT get the proper folder in every situation.
             * The user will have the oppurtunity to change it.
             * The reason I am keeping it simple here is because I do not know what method Firefox uses to
             * determine the proper folder to user on every platform, nor a 100% way to get the right folder
             * on every platform. */

            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string downloads = "Downloads";

            return Path.Combine(userFolder, downloads);
        }

        static public Settings LoadSettings()
        {
            string settingsPath = GetSettingsPath();

            if (File.Exists(settingsPath))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

                using (FileStream fs = new FileStream(settingsPath, FileMode.Open))
                {
                    using (DeflateStream ds = new DeflateStream(fs, CompressionMode.Decompress))
                    {
                        return (Settings)xmlSerializer.Deserialize(ds);
                    }
                }
            }
            else
            {
                return new Settings();
            }
        }
    }
}
