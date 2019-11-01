namespace Save_In_Companion
{
    partial class SaveInCompanionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveInCompanionForm));
            this.buildButton = new System.Windows.Forms.Button();
            this.tabview = new System.Windows.Forms.TabControl();
            this.entryTab = new System.Windows.Forms.TabPage();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addWithSub = new System.Windows.Forms.Button();
            this.selectedEntryProperties = new System.Windows.Forms.GroupBox();
            this.removeAllSubentriesButton = new System.Windows.Forms.Button();
            this.addAllSubFoldersButton = new System.Windows.Forms.Button();
            this.entryToEntryButton = new System.Windows.Forms.Button();
            this.commentPropertyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namePropertTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryPropertyTextBox = new System.Windows.Forms.TextBox();
            this.seperatorButton = new System.Windows.Forms.Button();
            this.moveEntryDownButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.expandNodesButton = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.moveEntryUp = new System.Windows.Forms.Button();
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.disableLinkCreation = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.markSaveInLinksfolderSystemCheck = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.markSaveInFolderHiddenCheck = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.saveFolderNameText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.downloadsButton = new System.Windows.Forms.Button();
            this.downloadsLocationTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.disableBackLinkCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.startBackLinkText = new System.Windows.Forms.TextBox();
            this.linkBackOnBottomCheck = new System.Windows.Forms.CheckBox();
            this.expandNodesOption = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.forceLinkBackCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backLinkEndTextBox = new System.Windows.Forms.TextBox();
            this.includeNameBackLinkCheck = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outputTab = new System.Windows.Forms.TabPage();
            this.copyButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabview.SuspendLayout();
            this.entryTab.SuspendLayout();
            this.selectedEntryProperties.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outputTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(652, 238);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(213, 23);
            this.buildButton.TabIndex = 9;
            this.buildButton.Text = "💾 Save && Build Output";
            this.buildButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.build_Click);
            // 
            // tabview
            // 
            this.tabview.Controls.Add(this.entryTab);
            this.tabview.Controls.Add(this.settingsTab);
            this.tabview.Controls.Add(this.outputTab);
            this.tabview.Location = new System.Drawing.Point(12, 12);
            this.tabview.Multiline = true;
            this.tabview.Name = "tabview";
            this.tabview.SelectedIndex = 0;
            this.tabview.Size = new System.Drawing.Size(1000, 493);
            this.tabview.TabIndex = 0;
            // 
            // entryTab
            // 
            this.entryTab.BackColor = System.Drawing.SystemColors.Control;
            this.entryTab.Controls.Add(this.addCategoryButton);
            this.entryTab.Controls.Add(this.addWithSub);
            this.entryTab.Controls.Add(this.buildButton);
            this.entryTab.Controls.Add(this.selectedEntryProperties);
            this.entryTab.Controls.Add(this.seperatorButton);
            this.entryTab.Controls.Add(this.moveEntryDownButton);
            this.entryTab.Controls.Add(this.removeButton);
            this.entryTab.Controls.Add(this.expandNodesButton);
            this.entryTab.Controls.Add(this.Add);
            this.entryTab.Controls.Add(this.moveEntryUp);
            this.entryTab.Controls.Add(this.directoryTree);
            this.entryTab.Location = new System.Drawing.Point(4, 22);
            this.entryTab.Name = "entryTab";
            this.entryTab.Padding = new System.Windows.Forms.Padding(3);
            this.entryTab.Size = new System.Drawing.Size(992, 467);
            this.entryTab.TabIndex = 0;
            this.entryTab.Text = "Menu";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(652, 151);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(213, 23);
            this.addCategoryButton.TabIndex = 6;
            this.addCategoryButton.Text = "⧉ Add Top Level Category Entry";
            this.addCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // addWithSub
            // 
            this.addWithSub.Location = new System.Drawing.Point(652, 122);
            this.addWithSub.Name = "addWithSub";
            this.addWithSub.Size = new System.Drawing.Size(213, 23);
            this.addWithSub.TabIndex = 5;
            this.addWithSub.Text = "➕➕ Add Top Level Entry (w/Subfolders)";
            this.addWithSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWithSub.UseVisualStyleBackColor = true;
            this.addWithSub.Click += new System.EventHandler(this.Add_Click);
            // 
            // selectedEntryProperties
            // 
            this.selectedEntryProperties.Controls.Add(this.removeAllSubentriesButton);
            this.selectedEntryProperties.Controls.Add(this.addAllSubFoldersButton);
            this.selectedEntryProperties.Controls.Add(this.entryToEntryButton);
            this.selectedEntryProperties.Controls.Add(this.commentPropertyTextBox);
            this.selectedEntryProperties.Controls.Add(this.label3);
            this.selectedEntryProperties.Controls.Add(this.namePropertTextBox);
            this.selectedEntryProperties.Controls.Add(this.label2);
            this.selectedEntryProperties.Controls.Add(this.label1);
            this.selectedEntryProperties.Controls.Add(this.directoryPropertyTextBox);
            this.selectedEntryProperties.Location = new System.Drawing.Point(652, 264);
            this.selectedEntryProperties.Name = "selectedEntryProperties";
            this.selectedEntryProperties.Size = new System.Drawing.Size(334, 197);
            this.selectedEntryProperties.TabIndex = 9;
            this.selectedEntryProperties.TabStop = false;
            // 
            // removeAllSubentriesButton
            // 
            this.removeAllSubentriesButton.Location = new System.Drawing.Point(6, 84);
            this.removeAllSubentriesButton.Name = "removeAllSubentriesButton";
            this.removeAllSubentriesButton.Size = new System.Drawing.Size(140, 23);
            this.removeAllSubentriesButton.TabIndex = 2;
            this.removeAllSubentriesButton.Text = "➖  Remove All Subentries";
            this.removeAllSubentriesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeAllSubentriesButton.UseVisualStyleBackColor = true;
            this.removeAllSubentriesButton.Click += new System.EventHandler(this.removeAllSubentriesButton_Click);
            // 
            // addAllSubFoldersButton
            // 
            this.addAllSubFoldersButton.Location = new System.Drawing.Point(108, 54);
            this.addAllSubFoldersButton.Name = "addAllSubFoldersButton";
            this.addAllSubFoldersButton.Size = new System.Drawing.Size(165, 23);
            this.addAllSubFoldersButton.TabIndex = 1;
            this.addAllSubFoldersButton.Text = "➕➕ Add All Subfolders Entries";
            this.addAllSubFoldersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAllSubFoldersButton.UseVisualStyleBackColor = true;
            this.addAllSubFoldersButton.Click += new System.EventHandler(this.addAllSubFoldersButton_Click);
            // 
            // entryToEntryButton
            // 
            this.entryToEntryButton.Location = new System.Drawing.Point(6, 54);
            this.entryToEntryButton.Name = "entryToEntryButton";
            this.entryToEntryButton.Size = new System.Drawing.Size(96, 23);
            this.entryToEntryButton.TabIndex = 0;
            this.entryToEntryButton.Text = "➕ Add Subentry";
            this.entryToEntryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entryToEntryButton.UseVisualStyleBackColor = true;
            this.entryToEntryButton.Click += new System.EventHandler(this.entryToEntryButton_Click);
            // 
            // commentPropertyTextBox
            // 
            this.commentPropertyTextBox.Location = new System.Drawing.Point(6, 165);
            this.commentPropertyTextBox.Name = "commentPropertyTextBox";
            this.commentPropertyTextBox.Size = new System.Drawing.Size(322, 20);
            this.commentPropertyTextBox.TabIndex = 4;
            this.commentPropertyTextBox.Leave += new System.EventHandler(this.commentPropertyTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comment";
            // 
            // namePropertTextBox
            // 
            this.namePropertTextBox.Location = new System.Drawing.Point(6, 126);
            this.namePropertTextBox.Name = "namePropertTextBox";
            this.namePropertTextBox.Size = new System.Drawing.Size(322, 20);
            this.namePropertTextBox.TabIndex = 3;
            this.namePropertTextBox.Leave += new System.EventHandler(this.namePropertTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory";
            // 
            // directoryPropertyTextBox
            // 
            this.directoryPropertyTextBox.Location = new System.Drawing.Point(6, 32);
            this.directoryPropertyTextBox.Name = "directoryPropertyTextBox";
            this.directoryPropertyTextBox.ReadOnly = true;
            this.directoryPropertyTextBox.Size = new System.Drawing.Size(322, 20);
            this.directoryPropertyTextBox.TabIndex = 0;
            // 
            // seperatorButton
            // 
            this.seperatorButton.Location = new System.Drawing.Point(652, 180);
            this.seperatorButton.Name = "seperatorButton";
            this.seperatorButton.Size = new System.Drawing.Size(213, 23);
            this.seperatorButton.TabIndex = 7;
            this.seperatorButton.Text = "✱ Add Top Level Seperator";
            this.seperatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seperatorButton.UseVisualStyleBackColor = true;
            this.seperatorButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // moveEntryDownButton
            // 
            this.moveEntryDownButton.Location = new System.Drawing.Point(652, 64);
            this.moveEntryDownButton.Name = "moveEntryDownButton";
            this.moveEntryDownButton.Size = new System.Drawing.Size(213, 23);
            this.moveEntryDownButton.TabIndex = 3;
            this.moveEntryDownButton.Text = "▼ Move Entry Down";
            this.moveEntryDownButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveEntryDownButton.UseVisualStyleBackColor = true;
            this.moveEntryDownButton.Click += new System.EventHandler(this.moveEntryDownButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(652, 209);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(213, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "➖  Remove Entry";
            this.removeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // expandNodesButton
            // 
            this.expandNodesButton.Location = new System.Drawing.Point(652, 6);
            this.expandNodesButton.Name = "expandNodesButton";
            this.expandNodesButton.Size = new System.Drawing.Size(213, 23);
            this.expandNodesButton.TabIndex = 1;
            this.expandNodesButton.Text = "📂 Expand Full Tree";
            this.expandNodesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandNodesButton.UseVisualStyleBackColor = true;
            this.expandNodesButton.Click += new System.EventHandler(this.expandNodesButton_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(652, 93);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(213, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "➕ Add Top Level Entry";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // moveEntryUp
            // 
            this.moveEntryUp.Location = new System.Drawing.Point(652, 35);
            this.moveEntryUp.Name = "moveEntryUp";
            this.moveEntryUp.Size = new System.Drawing.Size(213, 23);
            this.moveEntryUp.TabIndex = 2;
            this.moveEntryUp.Text = "▲ Move Entry Up";
            this.moveEntryUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moveEntryUp.UseVisualStyleBackColor = true;
            this.moveEntryUp.Click += new System.EventHandler(this.moveEntryUp_Click);
            // 
            // directoryTree
            // 
            this.directoryTree.HideSelection = false;
            this.directoryTree.Location = new System.Drawing.Point(0, 0);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.Size = new System.Drawing.Size(646, 461);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.settingsTab.Controls.Add(this.disableLinkCreation);
            this.settingsTab.Controls.Add(this.label17);
            this.settingsTab.Controls.Add(this.groupBox1);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(992, 467);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.Leave += new System.EventHandler(this.settingtag_Leave);
            // 
            // disableLinkCreation
            // 
            this.disableLinkCreation.AutoSize = true;
            this.disableLinkCreation.Location = new System.Drawing.Point(888, 82);
            this.disableLinkCreation.Name = "disableLinkCreation";
            this.disableLinkCreation.Size = new System.Drawing.Size(15, 14);
            this.disableLinkCreation.TabIndex = 0;
            this.disableLinkCreation.UseVisualStyleBackColor = true;
            this.disableLinkCreation.CheckedChanged += new System.EventHandler(this.disableLinkCreation_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(706, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 17);
            this.label17.TabIndex = 15;
            this.label17.Text = "Disable all link creation:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.markSaveInLinksfolderSystemCheck);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.markSaveInFolderHiddenCheck);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.saveFolderNameText);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.downloadsButton);
            this.groupBox1.Controls.Add(this.downloadsLocationTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.disableBackLinkCheck);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.startBackLinkText);
            this.groupBox1.Controls.Add(this.linkBackOnBottomCheck);
            this.groupBox1.Controls.Add(this.expandNodesOption);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.forceLinkBackCheck);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.backLinkEndTextBox);
            this.groupBox1.Controls.Add(this.includeNameBackLinkCheck);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 424);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(428, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 1;
            // 
            // markSaveInLinksfolderSystemCheck
            // 
            this.markSaveInLinksfolderSystemCheck.AutoSize = true;
            this.markSaveInLinksfolderSystemCheck.Location = new System.Drawing.Point(407, 154);
            this.markSaveInLinksfolderSystemCheck.Name = "markSaveInLinksfolderSystemCheck";
            this.markSaveInLinksfolderSystemCheck.Size = new System.Drawing.Size(15, 14);
            this.markSaveInLinksfolderSystemCheck.TabIndex = 3;
            this.markSaveInLinksfolderSystemCheck.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 154);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(321, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Mark the Save In Links folder as system protected (Windows only):";
            // 
            // markSaveInFolderHiddenCheck
            // 
            this.markSaveInFolderHiddenCheck.AutoSize = true;
            this.markSaveInFolderHiddenCheck.Location = new System.Drawing.Point(407, 128);
            this.markSaveInFolderHiddenCheck.Name = "markSaveInFolderHiddenCheck";
            this.markSaveInFolderHiddenCheck.Size = new System.Drawing.Size(15, 14);
            this.markSaveInFolderHiddenCheck.TabIndex = 2;
            this.markSaveInFolderHiddenCheck.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(273, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Mark the Save In Links folder as hidden (Windows only):";
            // 
            // saveFolderNameText
            // 
            this.saveFolderNameText.Location = new System.Drawing.Point(407, 99);
            this.saveFolderNameText.Name = "saveFolderNameText";
            this.saveFolderNameText.Size = new System.Drawing.Size(144, 20);
            this.saveFolderNameText.TabIndex = 1;
            this.saveFolderNameText.TextChanged += new System.EventHandler(this.saveFolderNameText_TextChanged);
            this.saveFolderNameText.Leave += new System.EventHandler(this.saveFolderNameText_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(306, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Name of Save In Links folder that will be created in Downloads:";
            // 
            // downloadsButton
            // 
            this.downloadsButton.Location = new System.Drawing.Point(470, 67);
            this.downloadsButton.Name = "downloadsButton";
            this.downloadsButton.Size = new System.Drawing.Size(87, 23);
            this.downloadsButton.TabIndex = 0;
            this.downloadsButton.Text = "Browse";
            this.downloadsButton.UseVisualStyleBackColor = true;
            this.downloadsButton.Click += new System.EventHandler(this.downloadsButton_Click);
            // 
            // downloadsLocationTextBox
            // 
            this.downloadsLocationTextBox.Location = new System.Drawing.Point(15, 69);
            this.downloadsLocationTextBox.Name = "downloadsLocationTextBox";
            this.downloadsLocationTextBox.ReadOnly = true;
            this.downloadsLocationTextBox.Size = new System.Drawing.Size(449, 20);
            this.downloadsLocationTextBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Downloads folder location:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(389, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Make sure this is your profile\'s Downloads folder that Save In will have access t" +
    "o.";
            // 
            // disableBackLinkCheck
            // 
            this.disableBackLinkCheck.AutoSize = true;
            this.disableBackLinkCheck.Location = new System.Drawing.Point(407, 258);
            this.disableBackLinkCheck.Name = "disableBackLinkCheck";
            this.disableBackLinkCheck.Size = new System.Drawing.Size(15, 14);
            this.disableBackLinkCheck.TabIndex = 5;
            this.disableBackLinkCheck.UseVisualStyleBackColor = true;
            this.disableBackLinkCheck.CheckedChanged += new System.EventHandler(this.disableBackLinkCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Auto expand nodes when entries are added: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Disable link back entry:";
            // 
            // startBackLinkText
            // 
            this.startBackLinkText.Location = new System.Drawing.Point(407, 281);
            this.startBackLinkText.Name = "startBackLinkText";
            this.startBackLinkText.Size = new System.Drawing.Size(144, 20);
            this.startBackLinkText.TabIndex = 6;
            this.startBackLinkText.TextChanged += new System.EventHandler(this.startBackLinkText_TextChanged);
            // 
            // linkBackOnBottomCheck
            // 
            this.linkBackOnBottomCheck.AutoSize = true;
            this.linkBackOnBottomCheck.Location = new System.Drawing.Point(407, 388);
            this.linkBackOnBottomCheck.Name = "linkBackOnBottomCheck";
            this.linkBackOnBottomCheck.Size = new System.Drawing.Size(15, 14);
            this.linkBackOnBottomCheck.TabIndex = 10;
            this.linkBackOnBottomCheck.UseVisualStyleBackColor = true;
            this.linkBackOnBottomCheck.CheckedChanged += new System.EventHandler(this.linkBackOnBottomCheck_CheckedChanged);
            // 
            // expandNodesOption
            // 
            this.expandNodesOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expandNodesOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.expandNodesOption.FormattingEnabled = true;
            this.expandNodesOption.Items.AddRange(new object[] {
            "Don\'t Auto Expand",
            "Auto Expand One Level",
            "Auto Expand All Levels"});
            this.expandNodesOption.Location = new System.Drawing.Point(407, 177);
            this.expandNodesOption.Name = "expandNodesOption";
            this.expandNodesOption.Size = new System.Drawing.Size(144, 21);
            this.expandNodesOption.TabIndex = 4;
            this.expandNodesOption.SelectedIndexChanged += new System.EventHandler(this.expandNodesOption_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Put link back at the bottom of the submenu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(4, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // forceLinkBackCheck
            // 
            this.forceLinkBackCheck.AutoSize = true;
            this.forceLinkBackCheck.Location = new System.Drawing.Point(407, 362);
            this.forceLinkBackCheck.Name = "forceLinkBackCheck";
            this.forceLinkBackCheck.Size = new System.Drawing.Size(15, 14);
            this.forceLinkBackCheck.TabIndex = 9;
            this.forceLinkBackCheck.UseVisualStyleBackColor = true;
            this.forceLinkBackCheck.CheckedChanged += new System.EventHandler(this.forceLinkBackCheck_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Automatically add text to start of a link back entry:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(347, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Always create a link back after top level, even if there are no subentries:";
            // 
            // endBackLinkText
            // 
            this.backLinkEndTextBox.Location = new System.Drawing.Point(407, 307);
            this.backLinkEndTextBox.Name = "endBackLinkText";
            this.backLinkEndTextBox.Size = new System.Drawing.Size(144, 20);
            this.backLinkEndTextBox.TabIndex = 7;
            this.backLinkEndTextBox.TextChanged += new System.EventHandler(this.endBackLinkText_TextChanged);
            // 
            // includeNameBackLinkCheck
            // 
            this.includeNameBackLinkCheck.AutoSize = true;
            this.includeNameBackLinkCheck.Location = new System.Drawing.Point(407, 336);
            this.includeNameBackLinkCheck.Name = "includeNameBackLinkCheck";
            this.includeNameBackLinkCheck.Size = new System.Drawing.Size(15, 14);
            this.includeNameBackLinkCheck.TabIndex = 8;
            this.includeNameBackLinkCheck.UseVisualStyleBackColor = true;
            this.includeNameBackLinkCheck.CheckedChanged += new System.EventHandler(this.includeNameBackLinkCheck_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Automatically add text to end of a link back entry:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Include the entry name in the back link:";
            // 
            // outputTab
            // 
            this.outputTab.BackColor = System.Drawing.SystemColors.Control;
            this.outputTab.Controls.Add(this.copyButton);
            this.outputTab.Controls.Add(this.outputTextBox);
            this.outputTab.Location = new System.Drawing.Point(4, 22);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(992, 467);
            this.outputTab.TabIndex = 1;
            this.outputTab.Text = "Output";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(887, 407);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(99, 23);
            this.copyButton.TabIndex = 0;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(986, 401);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.WordWrap = false;
            // 
            // SaveInCompanionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 517);
            this.Controls.Add(this.tabview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaveInCompanionForm";
            this.Text = "Save In Companion";
            this.tabview.ResumeLayout(false);
            this.entryTab.ResumeLayout(false);
            this.selectedEntryProperties.ResumeLayout(false);
            this.selectedEntryProperties.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.outputTab.ResumeLayout(false);
            this.outputTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.TabControl tabview;
        private System.Windows.Forms.TabPage entryTab;
        private System.Windows.Forms.TabPage outputTab;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button seperatorButton;
        private System.Windows.Forms.Button moveEntryUp;
        private System.Windows.Forms.Button moveEntryDownButton;
        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.Button expandNodesButton;
        private System.Windows.Forms.GroupBox selectedEntryProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox directoryPropertyTextBox;
        private System.Windows.Forms.TextBox commentPropertyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namePropertTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addWithSub;
        private System.Windows.Forms.Button addAllSubFoldersButton;
        private System.Windows.Forms.Button entryToEntryButton;
        private System.Windows.Forms.Button removeAllSubentriesButton;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.ComboBox expandNodesOption;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startBackLinkText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox backLinkEndTextBox;
        private System.Windows.Forms.CheckBox includeNameBackLinkCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox forceLinkBackCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox linkBackOnBottomCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox disableBackLinkCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button downloadsButton;
        private System.Windows.Forms.TextBox downloadsLocationTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox saveFolderNameText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox markSaveInLinksfolderSystemCheck;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox markSaveInFolderHiddenCheck;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox disableLinkCreation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button addCategoryButton;
    }
}

