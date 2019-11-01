using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Save_In_Companion
{
    public partial class SaveInCompanionForm : Form
    {
        Settings settings;

        bool ANodeIsSelected { get { return directoryTree.SelectedNode != null; } }

        public SaveInCompanionForm()
        {
            InitializeComponent();
            settings = Settings.LoadSettings();

            LoadEntriesToTreeView(settings.MenuEntries, directoryTree.Nodes);

            if (directoryTree.Nodes.Count > 0)
            {
                directoryTree.SelectedNode = directoryTree.Nodes[0];

                if (settings.AutoExpandOption != AutoExpandOption.Disabled)
                {
                    for (int i = 0; i < directoryTree.Nodes.Count; i++)
                    {
                        if (settings.AutoExpandOption == AutoExpandOption.OneLevel)
                        {
                            directoryTree.Nodes[i].Expand();
                        }
                        else if (settings.AutoExpandOption == AutoExpandOption.All)
                        {
                            directoryTree.Nodes[i].ExpandAll();
                        }
                    }
                }
            }

            expandNodesOption.SelectedIndex = (int)settings.AutoExpandOption;

            startBackLinkText.Text = settings.BackLinkStartText;

            backLinkEndTextBox.Text = settings.BackLinkEndText;

            includeNameBackLinkCheck.Checked = settings.IncludeNameInBackLink;

            forceLinkBackCheck.Checked = settings.ForceLinkBack;

            linkBackOnBottomCheck.Checked = settings.LinkBackOnBottom;

            disableBackLinkCheck.Checked = settings.DisableLinkBack;

            downloadsLocationTextBox.Text = settings.DownloadsFolderPath;

            saveFolderNameText.Text = settings.SaveInLinksFolderName;

            markSaveInFolderHiddenCheck.Checked = settings.HideSaveInFolderInWindows;

            markSaveInLinksfolderSystemCheck.Checked = settings.MarkSaveInFolderAsSystemInWindows;

            disableLinkCreation.Checked = settings.SkipLinkCreation;

            if (settings.FirstTimeRun)
            {
                settings.FirstTimeRun = false;
                tabview.SelectTab("settingsTab");
            }

            //HACK: Mono doesn't like the unicode on my buttons, it seems.
            if (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
            {
                for (int i = 0; i < tabview.TabPages[0].Controls.Count; i++)
                {
                    Button offendingButton = tabview.TabPages[0].Controls[i] as Button;

                    if (offendingButton != null)
                    {
                        Regex regex = new Regex("[^a-zA-Z0-9 -/&&]");
                        offendingButton.Text = regex.Replace(offendingButton.Text, "");
                    }
                }
                for (int i = 0; i < selectedEntryProperties.Controls.Count; i++)
                {
                    Button offendingButton = selectedEntryProperties.Controls[i] as Button;

                    if (offendingButton != null)
                    {
                        Regex regex = new Regex("[^a-zA-Z0-9 -]");
                        offendingButton.Text = regex.Replace(offendingButton.Text, "");
                    }
                }
            }
        }

        private void LoadEntriesToTreeView(List<MenuEntry> menuEntries, TreeNodeCollection nodeCollection)
        {

            for (int i = 0; i < menuEntries.Count; i++)
            {
                TreeNode node = new TreeNode(menuEntries[i].ToString());

                node.Tag = menuEntries[i];

                nodeCollection.Add(node);

                LoadEntriesToTreeView(menuEntries[i].SubEntries, nodeCollection[i].Nodes);
            }
        }





        private void build_Click(object sender, EventArgs e)
        {
            settings.SaveSettings();

            if (!settings.SkipLinkCreation)
            {
                if (!Directory.Exists(settings.SaveInLinksFolderPath))
                {
                    DirectoryInfo directory = Directory.CreateDirectory(settings.SaveInLinksFolderPath);
                    if (settings.MarkSaveInFolderAsSystemInWindows)
                    {
                        directory.Attributes = FileAttributes.Directory | FileAttributes.Hidden | FileAttributes.System;
                    }
                    else if (settings.HideSaveInFolderInWindows)
                    {
                        directory.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    }
                }
            }
            using (StringWriter tx = new StringWriter())
            {
                for (int i = 0; i < settings.MenuEntries.Count; i++)
                {
                    settings.MenuEntries[i].BuildOutput(tx, settings);
                }

                outputTextBox.Text = tx.ToString();
            }

            tabview.SelectTab("outputTab");

        }


        private void Add_Click(object sender, EventArgs e)
        {
            MenuEntry menuEntry = new MenuEntry();

            if (sender == seperatorButton)
            {
                menuEntry.IsSeperator = true;
            }
            else if (sender == addCategoryButton)
            {
                menuEntry.FolderPath = ".";
                menuEntry.Name = "Category";
                menuEntry.Deepness = 0;
                menuEntry.IsCategory = true;
            }
            else if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                menuEntry.FolderPath = folderBrowserDialog.SelectedPath;
                menuEntry.Name = Path.GetFileName(folderBrowserDialog.SelectedPath);
                menuEntry.Deepness = 0;
            }
            else
            {
                return;
            }

            int index;

            if (ANodeIsSelected)
            {
                TreeNode track = directoryTree.SelectedNode;

                while (track.Parent != null)
                {
                    track = track.Parent;
                }

                index = track.Index;
            }
            else
            {
                index = 0;
            }

            TreeNode node = new TreeNode(menuEntry.ToString());

            node.Tag = menuEntry;

            if (index >= settings.MenuEntries.Count)
            {
                settings.MenuEntries.Add(menuEntry);
                directoryTree.Nodes.Add(node);
            }
            else
            {
                settings.MenuEntries.Insert(index + 1, menuEntry);
                directoryTree.Nodes.Insert(index + 1, node);
            }

            directoryTree.SelectedNode = node;

            if (sender == addWithSub)
            {
                menuEntry.LoadSubdirectories(settings);
                LoadEntriesToTreeView(menuEntry.SubEntries, node.Nodes);
                if (settings.AutoExpandOption == AutoExpandOption.OneLevel)
                {
                    node.Expand();
                }
                else if (settings.AutoExpandOption == AutoExpandOption.All)
                {
                    node.ExpandAll();
                }
            }
            else if (sender == addCategoryButton)
            {
                namePropertTextBox.Select();

            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                TreeNode node = directoryTree.SelectedNode;
                TreeNode parentNode = directoryTree.SelectedNode.Parent;

                if (parentNode == null)
                {
                    directoryTree.Nodes.Remove(node);
                    settings.MenuEntries.Remove((MenuEntry)node.Tag);
                }
                else
                {
                    parentNode.Nodes.Remove(node);

                    MenuEntry entryParent = (MenuEntry)parentNode.Tag;
                    entryParent.SubEntries.Remove((MenuEntry)node.Tag);
                }
            }
        }



        private void moveEntryUp_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                int index = directoryTree.SelectedNode.Index;

                if (index > 0)
                {
                    TreeNode node = directoryTree.SelectedNode;
                    TreeNode parentNode = directoryTree.SelectedNode.Parent;


                    if (parentNode == null)
                    {

                        directoryTree.Nodes.RemoveAt(index);
                        directoryTree.Nodes.Insert(index - 1, node);

                        settings.MenuEntries.RemoveAt(index);
                        settings.MenuEntries.Insert(index - 1, (MenuEntry)node.Tag);

                    }
                    else
                    {
                        parentNode.Nodes.RemoveAt(index);
                        parentNode.Nodes.Insert(index - 1, node);

                        MenuEntry parentEntry = (MenuEntry)parentNode.Tag;

                        parentEntry.SubEntries.RemoveAt(index);
                        parentEntry.SubEntries.Insert(index - 1, (MenuEntry)node.Tag);
                    }

                    directoryTree.SelectedNode = node;
                }
            }
        }

        private void moveEntryDownButton_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                int index = directoryTree.SelectedNode.Index;
                TreeNode node = directoryTree.SelectedNode;
                TreeNode parentNode = directoryTree.SelectedNode.Parent;


                if (parentNode.Nodes.Count > index + 1)
                {
                    if (parentNode == null)
                    {

                        directoryTree.Nodes.RemoveAt(index);
                        directoryTree.Nodes.Insert(index + 1, node);

                        settings.MenuEntries.RemoveAt(index);
                        settings.MenuEntries.Insert(index + 1, (MenuEntry)node.Tag);

                    }
                    else
                    {
                        parentNode.Nodes.RemoveAt(index);
                        parentNode.Nodes.Insert(index + 1, node);

                        MenuEntry parentEntry = (MenuEntry)parentNode.Tag;

                        parentEntry.SubEntries.RemoveAt(index);
                        parentEntry.SubEntries.Insert(index + 1, (MenuEntry)node.Tag);
                    }

                    directoryTree.SelectedNode = node;
                }
            }
        }

        private void expandNodesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < directoryTree.Nodes.Count; i++)
            {
                directoryTree.Nodes[i].ExpandAll();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MenuEntry selected = (MenuEntry)directoryTree.SelectedNode.Tag;

            selectedEntryProperties.Enabled = !selected.IsSeperator;
            addAllSubFoldersButton.Enabled = !selected.IsCategory;

            directoryPropertyTextBox.Text = selected.FolderPath;
            namePropertTextBox.Text = selected.Name;
            commentPropertyTextBox.Text = selected.Comment;
        }

        private void namePropertTextBox_Leave(object sender, EventArgs e)
        {
            if (namePropertTextBox.Modified)
            {
                RenameEntry(namePropertTextBox.Text);
                namePropertTextBox.Modified = false;
            }
        }


        private void RenameEntry(string name)
        {
            if (ANodeIsSelected)
            {
                ((MenuEntry)directoryTree.SelectedNode.Tag).Name = name;
                directoryTree.SelectedNode.Text = ((MenuEntry)directoryTree.SelectedNode.Tag).ToString();

                directoryTree.Refresh();
            }
        }

        private void EditComment(string comment)
        {
            if (ANodeIsSelected)
            {
                ((MenuEntry)directoryTree.SelectedNode.Tag).Comment = comment;
                directoryTree.SelectedNode.Text = ((MenuEntry)directoryTree.SelectedNode.Tag).ToString();

                directoryTree.Refresh();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ActiveControl == namePropertTextBox)
                {
                    RenameEntry(namePropertTextBox.Text);
                    namePropertTextBox.Modified = false;
                    return true;
                }
                else if (ActiveControl == commentPropertyTextBox)
                {
                    EditComment(commentPropertyTextBox.Text);
                    commentPropertyTextBox.Modified = false;
                    return true;
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void commentPropertyTextBox_Leave(object sender, EventArgs e)
        {
            if (commentPropertyTextBox.Modified)
            {
                EditComment(commentPropertyTextBox.Text);
                namePropertTextBox.Modified = false;
            }
        }

        private void entryToEntryButton_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    TreeNode parentNode = directoryTree.SelectedNode;
                    MenuEntry parentEntry = (MenuEntry)parentNode.Tag;


                    MenuEntry menuEntry = new MenuEntry()
                    {
                        FolderPath = folderBrowserDialog.SelectedPath,
                        Name = Path.GetFileName(folderBrowserDialog.SelectedPath),
                        Deepness = parentEntry.Deepness + 1
                    };

                    TreeNode node = new TreeNode(menuEntry.ToString());

                    node.Tag = menuEntry;

                    parentNode.Nodes.Add(node);

                    parentEntry.SubEntries.Add(menuEntry);
                }
            }
        }

        private void addAllSubFoldersButton_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                MenuEntry menuEntry = (MenuEntry)directoryTree.SelectedNode.Tag;

                if (menuEntry.SubEntries.Count > 0 && MessageBox.Show("This entry already has a populated list of subentries. If you proceed with this, the old list and all modifcations to it will be deleted. If you wish to keep your current entries, press no and add any new entries with the Add Entry to Entry button. Do you wish to proceed?", "Subentries already exist here.", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    menuEntry.SubEntries.Clear();
                    directoryTree.SelectedNode.Nodes.Clear();

                    menuEntry.LoadSubdirectories(settings);

                    LoadEntriesToTreeView(menuEntry.SubEntries, directoryTree.SelectedNode.Nodes);

                    if (settings.AutoExpandOption == AutoExpandOption.OneLevel)
                    {
                        directoryTree.SelectedNode.Expand();
                    }
                    else if (settings.AutoExpandOption == AutoExpandOption.All)
                    {
                        directoryTree.SelectedNode.ExpandAll();
                    }
                }
            }
        }

        private void removeAllSubentriesButton_Click(object sender, EventArgs e)
        {
            if (ANodeIsSelected)
            {
                MenuEntry menuEntry = (MenuEntry)directoryTree.SelectedNode.Tag;
                menuEntry.SubEntries.Clear();
                directoryTree.SelectedNode.Nodes.Clear();
            }
        }

        private void expandNodesOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.AutoExpandOption = (AutoExpandOption)expandNodesOption.SelectedIndex;
        }

        private void settingtag_Leave(object sender, EventArgs e)
        {
            settings.SaveSettings();
        }

        private void startBackLinkText_TextChanged(object sender, EventArgs e)
        {
            settings.BackLinkStartText = startBackLinkText.Text;
        }

        private void endBackLinkText_TextChanged(object sender, EventArgs e)
        {
            settings.BackLinkEndText = backLinkEndTextBox.Text;
        }

        private void includeNameBackLinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.IncludeNameInBackLink = includeNameBackLinkCheck.Checked;
        }

        private void forceLinkBackCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.ForceLinkBack = forceLinkBackCheck.Checked;
        }

        private void linkBackOnBottomCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.LinkBackOnBottom = linkBackOnBottomCheck.Checked;
        }

        private void disableBackLinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.DisableLinkBack = disableBackLinkCheck.Checked;
        }

        private void downloadsButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                downloadsLocationTextBox.Text = folderBrowserDialog.SelectedPath;
                settings.DownloadsFolderPath = folderBrowserDialog.SelectedPath;
            }
        }

        private void saveFolderNameText_TextChanged(object sender, EventArgs e)
        {


            settings.SaveInLinksFolderName = saveFolderNameText.Text;
        }

        private void saveFolderNameText_Leave(object sender, EventArgs e)
        {
            string illegalChars = new string(System.IO.Path.GetInvalidFileNameChars());
            Regex regex = new Regex("[" + Regex.Escape(illegalChars) + "]");
            saveFolderNameText.Text = regex.Replace(saveFolderNameText.Text, "");

            if (string.IsNullOrWhiteSpace(saveFolderNameText.Text))
            {
                saveFolderNameText.Text = "SaveInLinks";
            }
            saveFolderNameText.Text = saveFolderNameText.Text.Trim();
        }

        private void markSaveInFolderHiddenCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.HideSaveInFolderInWindows = markSaveInFolderHiddenCheck.Checked;
        }

        private void markSaveInLinksfolderSystemCheck_CheckedChanged(object sender, EventArgs e)
        {
            settings.MarkSaveInFolderAsSystemInWindows = markSaveInLinksfolderSystemCheck.Checked;

            if (markSaveInLinksfolderSystemCheck.Checked)
            {
                markSaveInFolderHiddenCheck.Checked = true;
            }
        }

        private void disableLinkCreation_CheckedChanged(object sender, EventArgs e)
        {
            settings.SkipLinkCreation = disableLinkCreation.Checked;
        }

    }
}
