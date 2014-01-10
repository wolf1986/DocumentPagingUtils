using System.ComponentModel;
using System.Windows.Forms;

namespace DocumentPagingGui
{
    public partial class FrmMain : Form
    {
        #region Windows Form Designer generated code

        private FolderBrowserDialog folderBrowserDialog;
        private TabControl mainTabs;
        private TabPage tab1_Merge;
        private Label label3;
        private Label label2;
        private Button btnMerge;
        private Button btnBrowseMergeFile;
        private Label label1;
        private Button btnBrowseMergeDir;
        private TextBox edtMergeDir;
        private TextBox edtMergeFile;
        private TabPage tab3_Insert;
        private Button btnInsert;
        private CheckBox checkAppendToEnd;
        private Label label7;
        private Label label6;
        private Button btnBrowseInsertPages;
        private Label label5;
        private TextBox edtInsertPage;
        private Button btnBrowseInsertFile;
        private TextBox edtInsertFile;
        private Label label4;
        private TabPage tab4_Delete;
        private Button btnDelete;
        private Label label8;
        private Label label10;
        private TextBox edtDeletePageIndex;
        private Button btnBrowseDeleteFile;
        private TextBox edtDeleteFile;
        private Label label11;
        private TabPage tab2_Split;
        private Label label12;
        private Button btnBrowseSplitDir;
        private TextBox edtSplitDir;
        private Label label13;
        private Button btnBrowseSplitFile;
        private TextBox edtSplitFile;
        private Label label9;
        private Button btnSplit;
        private TabPage tab5_Reverse;
        private Label label14;
        private Button btnReverse;
        private Label label16;
        private Button btnBrowseReverseFile;
        private TextBox edtReverseFile;
        private TabPage tab6_Interleave;
        private Label label15;
        private Label label17;
        private Button btnInterleave;
        private Button btnBrowseInterleaveEven;
        private Label label18;
        private Button btnBrowseInterleaveOdd;
        private TextBox edtInterleaveOdd;
        private TextBox edtInterleaveEven;
        private CheckBox checkReverseEven;
        private TabPage tab0_About;
        private LinkLabel linkAbout;
        private Label label19;
        private CheckBox checkInsertNewFile;
        private CheckBox checkDeleteNewFile;
        private Label label20;
        private Button btnBrowseInterleaveOutFile;
        private TextBox edtInterleaveOutFile;
        private TextBox edtInsertAtIndex;
        private TabPage tab7_General;
        private CheckBox checkReverseNew;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tab0_About = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.tab1_Merge = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnBrowseMergeFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseMergeDir = new System.Windows.Forms.Button();
            this.edtMergeDir = new System.Windows.Forms.TextBox();
            this.edtMergeFile = new System.Windows.Forms.TextBox();
            this.tab2_Split = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBrowseSplitDir = new System.Windows.Forms.Button();
            this.edtSplitDir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBrowseSplitFile = new System.Windows.Forms.Button();
            this.edtSplitFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.tab3_Insert = new System.Windows.Forms.TabPage();
            this.checkInsertNewFile = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.checkAppendToEnd = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseInsertPages = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.edtInsertAtIndex = new System.Windows.Forms.TextBox();
            this.edtInsertPage = new System.Windows.Forms.TextBox();
            this.btnBrowseInsertFile = new System.Windows.Forms.Button();
            this.edtInsertFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tab4_Delete = new System.Windows.Forms.TabPage();
            this.checkDeleteNewFile = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edtDeletePageIndex = new System.Windows.Forms.TextBox();
            this.btnBrowseDeleteFile = new System.Windows.Forms.Button();
            this.edtDeleteFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tab5_Reverse = new System.Windows.Forms.TabPage();
            this.checkReverseNew = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBrowseReverseFile = new System.Windows.Forms.Button();
            this.edtReverseFile = new System.Windows.Forms.TextBox();
            this.tab6_Interleave = new System.Windows.Forms.TabPage();
            this.checkReverseEven = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBrowseInterleaveOutFile = new System.Windows.Forms.Button();
            this.btnInterleave = new System.Windows.Forms.Button();
            this.btnBrowseInterleaveEven = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBrowseInterleaveOdd = new System.Windows.Forms.Button();
            this.edtInterleaveOutFile = new System.Windows.Forms.TextBox();
            this.edtInterleaveOdd = new System.Windows.Forms.TextBox();
            this.edtInterleaveEven = new System.Windows.Forms.TextBox();
            this.tab7_General = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeneralRename = new System.Windows.Forms.Button();
            this.btnGeneralRenameBrowse = new System.Windows.Forms.Button();
            this.edtGeneralRenameDirectory = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGeneralAdjust = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btnGeneralAdjustBrowse = new System.Windows.Forms.Button();
            this.edtGeneralAdjustPath = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.edtGeneralAdjustBrightness = new System.Windows.Forms.TextBox();
            this.edtGeneralAdjustContrast = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.edtGeneralAdjustGamma = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.chkGeneralAdjustOverride = new System.Windows.Forms.CheckBox();
            this.mainTabs.SuspendLayout();
            this.tab0_About.SuspendLayout();
            this.tab1_Merge.SuspendLayout();
            this.tab2_Split.SuspendLayout();
            this.tab3_Insert.SuspendLayout();
            this.tab4_Delete.SuspendLayout();
            this.tab5_Reverse.SuspendLayout();
            this.tab6_Interleave.SuspendLayout();
            this.tab7_General.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.tab0_About);
            this.mainTabs.Controls.Add(this.tab1_Merge);
            this.mainTabs.Controls.Add(this.tab2_Split);
            this.mainTabs.Controls.Add(this.tab3_Insert);
            this.mainTabs.Controls.Add(this.tab4_Delete);
            this.mainTabs.Controls.Add(this.tab5_Reverse);
            this.mainTabs.Controls.Add(this.tab6_Interleave);
            this.mainTabs.Controls.Add(this.tab7_General);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabs.Location = new System.Drawing.Point(0, 40);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(569, 229);
            this.mainTabs.TabIndex = 0;
            // 
            // tab0_About
            // 
            this.tab0_About.BackColor = System.Drawing.Color.AliceBlue;
            this.tab0_About.Controls.Add(this.label19);
            this.tab0_About.Controls.Add(this.linkAbout);
            this.tab0_About.Location = new System.Drawing.Point(4, 25);
            this.tab0_About.Margin = new System.Windows.Forms.Padding(4);
            this.tab0_About.Name = "tab0_About";
            this.tab0_About.Padding = new System.Windows.Forms.Padding(4);
            this.tab0_About.Size = new System.Drawing.Size(561, 200);
            this.tab0_About.TabIndex = 6;
            this.tab0_About.Text = "About";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.ForeColor = System.Drawing.Color.DarkRed;
            this.label19.Location = new System.Drawing.Point(61, 29);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(469, 103);
            this.label19.TabIndex = 1;
            this.label19.Text = "Utility to manipulate *.djvu / *.tiff files and pages. \r\nAllows the use of ImageM" +
    "agick / DjVuLibre Utilities \r\nin a GUI environment.\r\n\r\nThis is Freeware, USE AT " +
    "OWN RISK!";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkAbout
            // 
            this.linkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkAbout.Location = new System.Drawing.Point(184, 170);
            this.linkAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(212, 25);
            this.linkAbout.TabIndex = 0;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "(C) The-Red-Pill.info";
            this.linkAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // tab1_Merge
            // 
            this.tab1_Merge.Controls.Add(this.label3);
            this.tab1_Merge.Controls.Add(this.label2);
            this.tab1_Merge.Controls.Add(this.btnMerge);
            this.tab1_Merge.Controls.Add(this.btnBrowseMergeFile);
            this.tab1_Merge.Controls.Add(this.label1);
            this.tab1_Merge.Controls.Add(this.btnBrowseMergeDir);
            this.tab1_Merge.Controls.Add(this.edtMergeDir);
            this.tab1_Merge.Controls.Add(this.edtMergeFile);
            this.tab1_Merge.Location = new System.Drawing.Point(4, 25);
            this.tab1_Merge.Margin = new System.Windows.Forms.Padding(4);
            this.tab1_Merge.Name = "tab1_Merge";
            this.tab1_Merge.Padding = new System.Windows.Forms.Padding(4);
            this.tab1_Merge.Size = new System.Drawing.Size(561, 200);
            this.tab1_Merge.TabIndex = 0;
            this.tab1_Merge.Text = "Merge";
            this.tab1_Merge.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Merge all the files in the given directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Out File:";
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMerge.Location = new System.Drawing.Point(240, 154);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(81, 27);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "Merge !";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnBrowseMergeFile
            // 
            this.btnBrowseMergeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMergeFile.Location = new System.Drawing.Point(472, 57);
            this.btnBrowseMergeFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseMergeFile.Name = "btnBrowseMergeFile";
            this.btnBrowseMergeFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseMergeFile.TabIndex = 3;
            this.btnBrowseMergeFile.Text = "Browse...";
            this.btnBrowseMergeFile.UseVisualStyleBackColor = true;
            this.btnBrowseMergeFile.Click += new System.EventHandler(this.btnBrowseMergeFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input Directory:";
            // 
            // btnBrowseMergeDir
            // 
            this.btnBrowseMergeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMergeDir.Location = new System.Drawing.Point(472, 28);
            this.btnBrowseMergeDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseMergeDir.Name = "btnBrowseMergeDir";
            this.btnBrowseMergeDir.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseMergeDir.TabIndex = 1;
            this.btnBrowseMergeDir.Text = "Browse...";
            this.btnBrowseMergeDir.UseVisualStyleBackColor = true;
            this.btnBrowseMergeDir.Click += new System.EventHandler(this.btnBrowseMergeDir_Click);
            // 
            // edtMergeDir
            // 
            this.edtMergeDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtMergeDir.Location = new System.Drawing.Point(133, 30);
            this.edtMergeDir.Margin = new System.Windows.Forms.Padding(4);
            this.edtMergeDir.Name = "edtMergeDir";
            this.edtMergeDir.Size = new System.Drawing.Size(331, 22);
            this.edtMergeDir.TabIndex = 0;
            // 
            // edtMergeFile
            // 
            this.edtMergeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtMergeFile.Location = new System.Drawing.Point(133, 60);
            this.edtMergeFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtMergeFile.Name = "edtMergeFile";
            this.edtMergeFile.Size = new System.Drawing.Size(331, 22);
            this.edtMergeFile.TabIndex = 2;
            // 
            // tab2_Split
            // 
            this.tab2_Split.Controls.Add(this.label12);
            this.tab2_Split.Controls.Add(this.btnBrowseSplitDir);
            this.tab2_Split.Controls.Add(this.edtSplitDir);
            this.tab2_Split.Controls.Add(this.label13);
            this.tab2_Split.Controls.Add(this.btnBrowseSplitFile);
            this.tab2_Split.Controls.Add(this.edtSplitFile);
            this.tab2_Split.Controls.Add(this.label9);
            this.tab2_Split.Controls.Add(this.btnSplit);
            this.tab2_Split.Location = new System.Drawing.Point(4, 25);
            this.tab2_Split.Margin = new System.Windows.Forms.Padding(4);
            this.tab2_Split.Name = "tab2_Split";
            this.tab2_Split.Padding = new System.Windows.Forms.Padding(4);
            this.tab2_Split.Size = new System.Drawing.Size(561, 200);
            this.tab2_Split.TabIndex = 3;
            this.tab2_Split.Text = "Split";
            this.tab2_Split.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Output Directory:";
            // 
            // btnBrowseSplitDir
            // 
            this.btnBrowseSplitDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSplitDir.Location = new System.Drawing.Point(472, 58);
            this.btnBrowseSplitDir.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseSplitDir.Name = "btnBrowseSplitDir";
            this.btnBrowseSplitDir.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseSplitDir.TabIndex = 3;
            this.btnBrowseSplitDir.Text = "Browse...";
            this.btnBrowseSplitDir.UseVisualStyleBackColor = true;
            this.btnBrowseSplitDir.Click += new System.EventHandler(this.btnBrowseSplitDir_Click);
            // 
            // edtSplitDir
            // 
            this.edtSplitDir.AllowDrop = true;
            this.edtSplitDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtSplitDir.Location = new System.Drawing.Point(127, 59);
            this.edtSplitDir.Margin = new System.Windows.Forms.Padding(4);
            this.edtSplitDir.Name = "edtSplitDir";
            this.edtSplitDir.Size = new System.Drawing.Size(337, 22);
            this.edtSplitDir.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Original File:";
            // 
            // btnBrowseSplitFile
            // 
            this.btnBrowseSplitFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSplitFile.Location = new System.Drawing.Point(472, 26);
            this.btnBrowseSplitFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseSplitFile.Name = "btnBrowseSplitFile";
            this.btnBrowseSplitFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseSplitFile.TabIndex = 1;
            this.btnBrowseSplitFile.Text = "Browse...";
            this.btnBrowseSplitFile.UseVisualStyleBackColor = true;
            this.btnBrowseSplitFile.Click += new System.EventHandler(this.btnBrowseSplitFile_Click);
            // 
            // edtSplitFile
            // 
            this.edtSplitFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtSplitFile.Location = new System.Drawing.Point(127, 27);
            this.edtSplitFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtSplitFile.Name = "edtSplitFile";
            this.edtSplitFile.Size = new System.Drawing.Size(337, 22);
            this.edtSplitFile.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Split a file to pages";
            // 
            // btnSplit
            // 
            this.btnSplit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSplit.Location = new System.Drawing.Point(240, 154);
            this.btnSplit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(81, 27);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Split !";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // tab3_Insert
            // 
            this.tab3_Insert.Controls.Add(this.checkInsertNewFile);
            this.tab3_Insert.Controls.Add(this.btnInsert);
            this.tab3_Insert.Controls.Add(this.checkAppendToEnd);
            this.tab3_Insert.Controls.Add(this.label7);
            this.tab3_Insert.Controls.Add(this.label6);
            this.tab3_Insert.Controls.Add(this.btnBrowseInsertPages);
            this.tab3_Insert.Controls.Add(this.label5);
            this.tab3_Insert.Controls.Add(this.edtInsertAtIndex);
            this.tab3_Insert.Controls.Add(this.edtInsertPage);
            this.tab3_Insert.Controls.Add(this.btnBrowseInsertFile);
            this.tab3_Insert.Controls.Add(this.edtInsertFile);
            this.tab3_Insert.Controls.Add(this.label4);
            this.tab3_Insert.Location = new System.Drawing.Point(4, 25);
            this.tab3_Insert.Margin = new System.Windows.Forms.Padding(4);
            this.tab3_Insert.Name = "tab3_Insert";
            this.tab3_Insert.Padding = new System.Windows.Forms.Padding(4);
            this.tab3_Insert.Size = new System.Drawing.Size(561, 200);
            this.tab3_Insert.TabIndex = 1;
            this.tab3_Insert.Text = "Insert";
            this.tab3_Insert.UseVisualStyleBackColor = true;
            // 
            // checkInsertNewFile
            // 
            this.checkInsertNewFile.AutoSize = true;
            this.checkInsertNewFile.Location = new System.Drawing.Point(14, 124);
            this.checkInsertNewFile.Margin = new System.Windows.Forms.Padding(4);
            this.checkInsertNewFile.Name = "checkInsertNewFile";
            this.checkInsertNewFile.Size = new System.Drawing.Size(316, 20);
            this.checkInsertNewFile.TabIndex = 6;
            this.checkInsertNewFile.Text = "Write output to a new file (leave the original intact)";
            this.checkInsertNewFile.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInsert.Location = new System.Drawing.Point(240, 159);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 27);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert !";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // checkAppendToEnd
            // 
            this.checkAppendToEnd.AutoSize = true;
            this.checkAppendToEnd.Location = new System.Drawing.Point(268, 95);
            this.checkAppendToEnd.Margin = new System.Windows.Forms.Padding(4);
            this.checkAppendToEnd.Name = "checkAppendToEnd";
            this.checkAppendToEnd.Size = new System.Drawing.Size(115, 20);
            this.checkAppendToEnd.TabIndex = 5;
            this.checkAppendToEnd.Text = "Append to end";
            this.checkAppendToEnd.UseVisualStyleBackColor = true;
            this.checkAppendToEnd.CheckedChanged += new System.EventHandler(this.checkAppendToEnd_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Put the new pages before page:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pages to insert:";
            // 
            // btnBrowseInsertPages
            // 
            this.btnBrowseInsertPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInsertPages.Location = new System.Drawing.Point(471, 58);
            this.btnBrowseInsertPages.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInsertPages.Name = "btnBrowseInsertPages";
            this.btnBrowseInsertPages.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseInsertPages.TabIndex = 3;
            this.btnBrowseInsertPages.Text = "Browse...";
            this.btnBrowseInsertPages.UseVisualStyleBackColor = true;
            this.btnBrowseInsertPages.Click += new System.EventHandler(this.btnBrowseInsertPages_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Original File:";
            // 
            // edtInsertAtIndex
            // 
            this.edtInsertAtIndex.Location = new System.Drawing.Point(216, 93);
            this.edtInsertAtIndex.Margin = new System.Windows.Forms.Padding(4);
            this.edtInsertAtIndex.MaxLength = 4;
            this.edtInsertAtIndex.Name = "edtInsertAtIndex";
            this.edtInsertAtIndex.Size = new System.Drawing.Size(30, 22);
            this.edtInsertAtIndex.TabIndex = 4;
            this.edtInsertAtIndex.Text = "1";
            this.edtInsertAtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edtInsertPage
            // 
            this.edtInsertPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInsertPage.Location = new System.Drawing.Point(124, 60);
            this.edtInsertPage.Margin = new System.Windows.Forms.Padding(4);
            this.edtInsertPage.Name = "edtInsertPage";
            this.edtInsertPage.Size = new System.Drawing.Size(339, 22);
            this.edtInsertPage.TabIndex = 2;
            // 
            // btnBrowseInsertFile
            // 
            this.btnBrowseInsertFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInsertFile.Location = new System.Drawing.Point(471, 26);
            this.btnBrowseInsertFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInsertFile.Name = "btnBrowseInsertFile";
            this.btnBrowseInsertFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseInsertFile.TabIndex = 1;
            this.btnBrowseInsertFile.Text = "Browse...";
            this.btnBrowseInsertFile.UseVisualStyleBackColor = true;
            this.btnBrowseInsertFile.Click += new System.EventHandler(this.btnBrowseInsertFile_Click);
            // 
            // edtInsertFile
            // 
            this.edtInsertFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInsertFile.Location = new System.Drawing.Point(124, 28);
            this.edtInsertFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtInsertFile.Name = "edtInsertFile";
            this.edtInsertFile.Size = new System.Drawing.Size(339, 22);
            this.edtInsertFile.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add a set of pages to an existing file";
            // 
            // tab4_Delete
            // 
            this.tab4_Delete.Controls.Add(this.checkDeleteNewFile);
            this.tab4_Delete.Controls.Add(this.btnDelete);
            this.tab4_Delete.Controls.Add(this.label8);
            this.tab4_Delete.Controls.Add(this.label10);
            this.tab4_Delete.Controls.Add(this.edtDeletePageIndex);
            this.tab4_Delete.Controls.Add(this.btnBrowseDeleteFile);
            this.tab4_Delete.Controls.Add(this.edtDeleteFile);
            this.tab4_Delete.Controls.Add(this.label11);
            this.tab4_Delete.Location = new System.Drawing.Point(4, 25);
            this.tab4_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.tab4_Delete.Name = "tab4_Delete";
            this.tab4_Delete.Padding = new System.Windows.Forms.Padding(4);
            this.tab4_Delete.Size = new System.Drawing.Size(561, 200);
            this.tab4_Delete.TabIndex = 2;
            this.tab4_Delete.Text = "Delete";
            this.tab4_Delete.UseVisualStyleBackColor = true;
            // 
            // checkDeleteNewFile
            // 
            this.checkDeleteNewFile.AutoSize = true;
            this.checkDeleteNewFile.Location = new System.Drawing.Point(14, 90);
            this.checkDeleteNewFile.Margin = new System.Windows.Forms.Padding(4);
            this.checkDeleteNewFile.Name = "checkDeleteNewFile";
            this.checkDeleteNewFile.Size = new System.Drawing.Size(316, 20);
            this.checkDeleteNewFile.TabIndex = 3;
            this.checkDeleteNewFile.Text = "Write output to a new file (leave the original intact)";
            this.checkDeleteNewFile.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(224, 154);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Page !";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Delete page number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Original File:";
            // 
            // edtDeletePageIndex
            // 
            this.edtDeletePageIndex.Location = new System.Drawing.Point(152, 62);
            this.edtDeletePageIndex.Margin = new System.Windows.Forms.Padding(4);
            this.edtDeletePageIndex.Name = "edtDeletePageIndex";
            this.edtDeletePageIndex.Size = new System.Drawing.Size(44, 22);
            this.edtDeletePageIndex.TabIndex = 2;
            this.edtDeletePageIndex.Text = "1";
            this.edtDeletePageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBrowseDeleteFile
            // 
            this.btnBrowseDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDeleteFile.Location = new System.Drawing.Point(472, 26);
            this.btnBrowseDeleteFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseDeleteFile.Name = "btnBrowseDeleteFile";
            this.btnBrowseDeleteFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseDeleteFile.TabIndex = 1;
            this.btnBrowseDeleteFile.Text = "Browse...";
            this.btnBrowseDeleteFile.UseVisualStyleBackColor = true;
            this.btnBrowseDeleteFile.Click += new System.EventHandler(this.btnBrowseDeleteFile_Click);
            // 
            // edtDeleteFile
            // 
            this.edtDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtDeleteFile.Location = new System.Drawing.Point(104, 28);
            this.edtDeleteFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtDeleteFile.Name = "edtDeleteFile";
            this.edtDeleteFile.Size = new System.Drawing.Size(360, 22);
            this.edtDeleteFile.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Remove a page from an existing file";
            // 
            // tab5_Reverse
            // 
            this.tab5_Reverse.Controls.Add(this.checkReverseNew);
            this.tab5_Reverse.Controls.Add(this.label14);
            this.tab5_Reverse.Controls.Add(this.btnReverse);
            this.tab5_Reverse.Controls.Add(this.label16);
            this.tab5_Reverse.Controls.Add(this.btnBrowseReverseFile);
            this.tab5_Reverse.Controls.Add(this.edtReverseFile);
            this.tab5_Reverse.Location = new System.Drawing.Point(4, 25);
            this.tab5_Reverse.Margin = new System.Windows.Forms.Padding(4);
            this.tab5_Reverse.Name = "tab5_Reverse";
            this.tab5_Reverse.Padding = new System.Windows.Forms.Padding(4);
            this.tab5_Reverse.Size = new System.Drawing.Size(561, 200);
            this.tab5_Reverse.TabIndex = 4;
            this.tab5_Reverse.Text = "Reverse";
            this.tab5_Reverse.UseVisualStyleBackColor = true;
            // 
            // checkReverseNew
            // 
            this.checkReverseNew.AutoSize = true;
            this.checkReverseNew.Location = new System.Drawing.Point(14, 58);
            this.checkReverseNew.Margin = new System.Windows.Forms.Padding(4);
            this.checkReverseNew.Name = "checkReverseNew";
            this.checkReverseNew.Size = new System.Drawing.Size(316, 20);
            this.checkReverseNew.TabIndex = 2;
            this.checkReverseNew.Text = "Write output to a new file (leave the original intact)";
            this.checkReverseNew.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Reverse the order of pages in the given file ";
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReverse.Location = new System.Drawing.Point(234, 154);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(4);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(93, 27);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Reverse !";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Input File:";
            // 
            // btnBrowseReverseFile
            // 
            this.btnBrowseReverseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseReverseFile.Location = new System.Drawing.Point(472, 27);
            this.btnBrowseReverseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseReverseFile.Name = "btnBrowseReverseFile";
            this.btnBrowseReverseFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseReverseFile.TabIndex = 1;
            this.btnBrowseReverseFile.Text = "Browse...";
            this.btnBrowseReverseFile.UseVisualStyleBackColor = true;
            this.btnBrowseReverseFile.Click += new System.EventHandler(this.btnBrowseReverseFile_Click);
            // 
            // edtReverseFile
            // 
            this.edtReverseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtReverseFile.Location = new System.Drawing.Point(89, 28);
            this.edtReverseFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtReverseFile.Name = "edtReverseFile";
            this.edtReverseFile.Size = new System.Drawing.Size(375, 22);
            this.edtReverseFile.TabIndex = 0;
            // 
            // tab6_Interleave
            // 
            this.tab6_Interleave.Controls.Add(this.checkReverseEven);
            this.tab6_Interleave.Controls.Add(this.label15);
            this.tab6_Interleave.Controls.Add(this.label20);
            this.tab6_Interleave.Controls.Add(this.label17);
            this.tab6_Interleave.Controls.Add(this.btnBrowseInterleaveOutFile);
            this.tab6_Interleave.Controls.Add(this.btnInterleave);
            this.tab6_Interleave.Controls.Add(this.btnBrowseInterleaveEven);
            this.tab6_Interleave.Controls.Add(this.label18);
            this.tab6_Interleave.Controls.Add(this.btnBrowseInterleaveOdd);
            this.tab6_Interleave.Controls.Add(this.edtInterleaveOutFile);
            this.tab6_Interleave.Controls.Add(this.edtInterleaveOdd);
            this.tab6_Interleave.Controls.Add(this.edtInterleaveEven);
            this.tab6_Interleave.Location = new System.Drawing.Point(4, 25);
            this.tab6_Interleave.Margin = new System.Windows.Forms.Padding(4);
            this.tab6_Interleave.Name = "tab6_Interleave";
            this.tab6_Interleave.Padding = new System.Windows.Forms.Padding(4);
            this.tab6_Interleave.Size = new System.Drawing.Size(561, 200);
            this.tab6_Interleave.TabIndex = 5;
            this.tab6_Interleave.Text = "Interleave";
            this.tab6_Interleave.UseVisualStyleBackColor = true;
            // 
            // checkReverseEven
            // 
            this.checkReverseEven.AutoSize = true;
            this.checkReverseEven.Location = new System.Drawing.Point(14, 93);
            this.checkReverseEven.Margin = new System.Windows.Forms.Padding(4);
            this.checkReverseEven.Name = "checkReverseEven";
            this.checkReverseEven.Size = new System.Drawing.Size(172, 20);
            this.checkReverseEven.TabIndex = 4;
            this.checkReverseEven.Text = "Even pages are reverse";
            this.checkReverseEven.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(327, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Interleave Odd and Even pages from two different files";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 124);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "Output file:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 66);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 16);
            this.label17.TabIndex = 11;
            this.label17.Text = "Even Pages:";
            // 
            // btnBrowseInterleaveOutFile
            // 
            this.btnBrowseInterleaveOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInterleaveOutFile.Location = new System.Drawing.Point(473, 118);
            this.btnBrowseInterleaveOutFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInterleaveOutFile.Name = "btnBrowseInterleaveOutFile";
            this.btnBrowseInterleaveOutFile.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseInterleaveOutFile.TabIndex = 6;
            this.btnBrowseInterleaveOutFile.Text = "Browse...";
            this.btnBrowseInterleaveOutFile.UseVisualStyleBackColor = true;
            this.btnBrowseInterleaveOutFile.Click += new System.EventHandler(this.btnBrowseInterleaveOutFile_Click);
            // 
            // btnInterleave
            // 
            this.btnInterleave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInterleave.Location = new System.Drawing.Point(230, 154);
            this.btnInterleave.Margin = new System.Windows.Forms.Padding(4);
            this.btnInterleave.Name = "btnInterleave";
            this.btnInterleave.Size = new System.Drawing.Size(101, 27);
            this.btnInterleave.TabIndex = 7;
            this.btnInterleave.Text = "Interleave !";
            this.btnInterleave.UseVisualStyleBackColor = true;
            this.btnInterleave.Click += new System.EventHandler(this.btnInterleave_Click);
            // 
            // btnBrowseInterleaveEven
            // 
            this.btnBrowseInterleaveEven.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInterleaveEven.Location = new System.Drawing.Point(473, 60);
            this.btnBrowseInterleaveEven.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInterleaveEven.Name = "btnBrowseInterleaveEven";
            this.btnBrowseInterleaveEven.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseInterleaveEven.TabIndex = 3;
            this.btnBrowseInterleaveEven.Text = "Browse...";
            this.btnBrowseInterleaveEven.UseVisualStyleBackColor = true;
            this.btnBrowseInterleaveEven.Click += new System.EventHandler(this.btnBrowseInterleaveEven_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 32);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "Odd Pages:";
            // 
            // btnBrowseInterleaveOdd
            // 
            this.btnBrowseInterleaveOdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInterleaveOdd.Location = new System.Drawing.Point(473, 26);
            this.btnBrowseInterleaveOdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInterleaveOdd.Name = "btnBrowseInterleaveOdd";
            this.btnBrowseInterleaveOdd.Size = new System.Drawing.Size(81, 27);
            this.btnBrowseInterleaveOdd.TabIndex = 1;
            this.btnBrowseInterleaveOdd.Text = "Browse...";
            this.btnBrowseInterleaveOdd.UseVisualStyleBackColor = true;
            this.btnBrowseInterleaveOdd.Click += new System.EventHandler(this.btnBrowseInterleaveOdd_Click);
            // 
            // edtInterleaveOutFile
            // 
            this.edtInterleaveOutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInterleaveOutFile.Location = new System.Drawing.Point(124, 121);
            this.edtInterleaveOutFile.Margin = new System.Windows.Forms.Padding(4);
            this.edtInterleaveOutFile.Name = "edtInterleaveOutFile";
            this.edtInterleaveOutFile.Size = new System.Drawing.Size(341, 22);
            this.edtInterleaveOutFile.TabIndex = 5;
            // 
            // edtInterleaveOdd
            // 
            this.edtInterleaveOdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInterleaveOdd.Location = new System.Drawing.Point(124, 28);
            this.edtInterleaveOdd.Margin = new System.Windows.Forms.Padding(4);
            this.edtInterleaveOdd.Name = "edtInterleaveOdd";
            this.edtInterleaveOdd.Size = new System.Drawing.Size(341, 22);
            this.edtInterleaveOdd.TabIndex = 0;
            // 
            // edtInterleaveEven
            // 
            this.edtInterleaveEven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtInterleaveEven.Location = new System.Drawing.Point(124, 63);
            this.edtInterleaveEven.Margin = new System.Windows.Forms.Padding(4);
            this.edtInterleaveEven.Name = "edtInterleaveEven";
            this.edtInterleaveEven.Size = new System.Drawing.Size(341, 22);
            this.edtInterleaveEven.TabIndex = 2;
            // 
            // tab7_General
            // 
            this.tab7_General.Controls.Add(this.groupBox2);
            this.tab7_General.Controls.Add(this.groupBox1);
            this.tab7_General.Location = new System.Drawing.Point(4, 25);
            this.tab7_General.Name = "tab7_General";
            this.tab7_General.Padding = new System.Windows.Forms.Padding(3);
            this.tab7_General.Size = new System.Drawing.Size(561, 200);
            this.tab7_General.TabIndex = 7;
            this.tab7_General.Text = "General";
            this.tab7_General.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "1) Select document type:";
            // 
            // cmbDocType
            // 
            this.cmbDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Location = new System.Drawing.Point(166, 6);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(399, 24);
            this.cmbDocType.TabIndex = 2;
            this.cmbDocType.SelectedIndexChanged += new System.EventHandler(this.cmbDocType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.btnGeneralRename);
            this.groupBox1.Controls.Add(this.btnGeneralRenameBrowse);
            this.groupBox1.Controls.Add(this.edtGeneralRenameDirectory);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 63);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rename all files in directory to their modified date (*.*)";
            // 
            // btnGeneralRename
            // 
            this.btnGeneralRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralRename.Location = new System.Drawing.Point(464, 22);
            this.btnGeneralRename.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneralRename.Name = "btnGeneralRename";
            this.btnGeneralRename.Size = new System.Drawing.Size(78, 27);
            this.btnGeneralRename.TabIndex = 21;
            this.btnGeneralRename.Text = "Rename !";
            this.btnGeneralRename.UseVisualStyleBackColor = true;
            this.btnGeneralRename.Click += new System.EventHandler(this.btnGeneralRename_Click);
            // 
            // btnGeneralRenameBrowse
            // 
            this.btnGeneralRenameBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralRenameBrowse.Location = new System.Drawing.Point(376, 22);
            this.btnGeneralRenameBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneralRenameBrowse.Name = "btnGeneralRenameBrowse";
            this.btnGeneralRenameBrowse.Size = new System.Drawing.Size(80, 27);
            this.btnGeneralRenameBrowse.TabIndex = 20;
            this.btnGeneralRenameBrowse.Text = "Browse...";
            this.btnGeneralRenameBrowse.UseVisualStyleBackColor = true;
            this.btnGeneralRenameBrowse.Click += new System.EventHandler(this.btnGeneralRenameBrowse_Click);
            // 
            // edtGeneralRenameDirectory
            // 
            this.edtGeneralRenameDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtGeneralRenameDirectory.Location = new System.Drawing.Point(106, 25);
            this.edtGeneralRenameDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.edtGeneralRenameDirectory.Name = "edtGeneralRenameDirectory";
            this.edtGeneralRenameDirectory.Size = new System.Drawing.Size(262, 22);
            this.edtGeneralRenameDirectory.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkGeneralAdjustOverride);
            this.groupBox2.Controls.Add(this.btnGeneralAdjust);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.edtGeneralAdjustGamma);
            this.groupBox2.Controls.Add(this.btnGeneralAdjustBrowse);
            this.groupBox2.Controls.Add(this.edtGeneralAdjustContrast);
            this.groupBox2.Controls.Add(this.edtGeneralAdjustBrightness);
            this.groupBox2.Controls.Add(this.edtGeneralAdjustPath);
            this.groupBox2.Location = new System.Drawing.Point(6, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 85);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjust colors of an image file (Jpg, Png, Tiff, etc...)";
            // 
            // btnGeneralAdjust
            // 
            this.btnGeneralAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralAdjust.Location = new System.Drawing.Point(464, 22);
            this.btnGeneralAdjust.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneralAdjust.Name = "btnGeneralAdjust";
            this.btnGeneralAdjust.Size = new System.Drawing.Size(78, 27);
            this.btnGeneralAdjust.TabIndex = 25;
            this.btnGeneralAdjust.Text = "Adjust !";
            this.btnGeneralAdjust.UseVisualStyleBackColor = true;
            this.btnGeneralAdjust.Click += new System.EventHandler(this.btnGeneralAdjust_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 27);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 16);
            this.label21.TabIndex = 26;
            this.label21.Text = "Input File / Dir:";
            // 
            // btnGeneralAdjustBrowse
            // 
            this.btnGeneralAdjustBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneralAdjustBrowse.Location = new System.Drawing.Point(376, 22);
            this.btnGeneralAdjustBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneralAdjustBrowse.Name = "btnGeneralAdjustBrowse";
            this.btnGeneralAdjustBrowse.Size = new System.Drawing.Size(81, 27);
            this.btnGeneralAdjustBrowse.TabIndex = 24;
            this.btnGeneralAdjustBrowse.Text = "Browse...";
            this.btnGeneralAdjustBrowse.UseVisualStyleBackColor = true;
            this.btnGeneralAdjustBrowse.Click += new System.EventHandler(this.btnGeneralAdjustBrowse_Click);
            // 
            // edtGeneralAdjustPath
            // 
            this.edtGeneralAdjustPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtGeneralAdjustPath.Location = new System.Drawing.Point(106, 25);
            this.edtGeneralAdjustPath.Margin = new System.Windows.Forms.Padding(4);
            this.edtGeneralAdjustPath.Name = "edtGeneralAdjustPath";
            this.edtGeneralAdjustPath.Size = new System.Drawing.Size(262, 22);
            this.edtGeneralAdjustPath.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 27);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 16);
            this.label22.TabIndex = 27;
            this.label22.Text = "Input File / Dir:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 56);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 16);
            this.label24.TabIndex = 26;
            this.label24.Text = "Brightness:";
            // 
            // edtGeneralAdjustBrightness
            // 
            this.edtGeneralAdjustBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtGeneralAdjustBrightness.Location = new System.Drawing.Point(89, 53);
            this.edtGeneralAdjustBrightness.Margin = new System.Windows.Forms.Padding(4);
            this.edtGeneralAdjustBrightness.Name = "edtGeneralAdjustBrightness";
            this.edtGeneralAdjustBrightness.Size = new System.Drawing.Size(42, 22);
            this.edtGeneralAdjustBrightness.TabIndex = 23;
            this.edtGeneralAdjustBrightness.Text = "1.0";
            this.edtGeneralAdjustBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edtGeneralAdjustContrast
            // 
            this.edtGeneralAdjustContrast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtGeneralAdjustContrast.Location = new System.Drawing.Point(204, 53);
            this.edtGeneralAdjustContrast.Margin = new System.Windows.Forms.Padding(4);
            this.edtGeneralAdjustContrast.Name = "edtGeneralAdjustContrast";
            this.edtGeneralAdjustContrast.Size = new System.Drawing.Size(42, 22);
            this.edtGeneralAdjustContrast.TabIndex = 23;
            this.edtGeneralAdjustContrast.Text = "1.0";
            this.edtGeneralAdjustContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(139, 56);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 16);
            this.label25.TabIndex = 26;
            this.label25.Text = "Contrast:";
            // 
            // edtGeneralAdjustGamma
            // 
            this.edtGeneralAdjustGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtGeneralAdjustGamma.Location = new System.Drawing.Point(319, 53);
            this.edtGeneralAdjustGamma.Margin = new System.Windows.Forms.Padding(4);
            this.edtGeneralAdjustGamma.Name = "edtGeneralAdjustGamma";
            this.edtGeneralAdjustGamma.Size = new System.Drawing.Size(42, 22);
            this.edtGeneralAdjustGamma.TabIndex = 23;
            this.edtGeneralAdjustGamma.Text = "1.0";
            this.edtGeneralAdjustGamma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(254, 56);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 16);
            this.label26.TabIndex = 26;
            this.label26.Text = "Gamma:";
            // 
            // chkGeneralAdjustOverride
            // 
            this.chkGeneralAdjustOverride.AutoSize = true;
            this.chkGeneralAdjustOverride.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGeneralAdjustOverride.Location = new System.Drawing.Point(368, 55);
            this.chkGeneralAdjustOverride.Name = "chkGeneralAdjustOverride";
            this.chkGeneralAdjustOverride.Size = new System.Drawing.Size(167, 20);
            this.chkGeneralAdjustOverride.TabIndex = 27;
            this.chkGeneralAdjustOverride.Text = "Override Original Files?";
            this.chkGeneralAdjustOverride.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 269);
            this.Controls.Add(this.cmbDocType);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.mainTabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "DocumentPagingGui";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mainTabs.ResumeLayout(false);
            this.tab0_About.ResumeLayout(false);
            this.tab1_Merge.ResumeLayout(false);
            this.tab1_Merge.PerformLayout();
            this.tab2_Split.ResumeLayout(false);
            this.tab2_Split.PerformLayout();
            this.tab3_Insert.ResumeLayout(false);
            this.tab3_Insert.PerformLayout();
            this.tab4_Delete.ResumeLayout(false);
            this.tab4_Delete.PerformLayout();
            this.tab5_Reverse.ResumeLayout(false);
            this.tab5_Reverse.PerformLayout();
            this.tab6_Interleave.ResumeLayout(false);
            this.tab6_Interleave.PerformLayout();
            this.tab7_General.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label23;
        private ComboBox cmbDocType;
        private GroupBox groupBox2;
        private Button btnGeneralAdjust;
        private Label label21;
        private Button btnGeneralAdjustBrowse;
        private TextBox edtGeneralAdjustPath;
        private GroupBox groupBox1;
        private Button btnGeneralRename;
        private Button btnGeneralRenameBrowse;
        private TextBox edtGeneralRenameDirectory;
        private Label label22;
        private Label label26;
        private Label label25;
        private Label label24;
        private TextBox edtGeneralAdjustGamma;
        private TextBox edtGeneralAdjustContrast;
        private TextBox edtGeneralAdjustBrightness;
        private CheckBox chkGeneralAdjustOverride;
    }
}
