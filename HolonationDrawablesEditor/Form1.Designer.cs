namespace HolonationDrawablesEditor
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkGoogleDrawablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkAppDrawablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitReplaceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeChangesToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.cbxGoogleDrawables = new System.Windows.Forms.ComboBox();
            this.rbnDark = new System.Windows.Forms.RadioButton();
            this.rbnLight = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwGoogleDrawables = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbnADark = new System.Windows.Forms.RadioButton();
            this.lvwAppDrawables = new System.Windows.Forms.ListView();
            this.rbnALight = new System.Windows.Forms.RadioButton();
            this.cbxAppDrawables = new System.Windows.Forms.ComboBox();
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwGenerateGoogle = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgwGenerateApp = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkGoogleDrawablesToolStripMenuItem,
            this.linkAppDrawablesToolStripMenuItem,
            this.exitReplaceModeToolStripMenuItem,
            this.writeChangesToFolderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linkGoogleDrawablesToolStripMenuItem
            // 
            this.linkGoogleDrawablesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("linkGoogleDrawablesToolStripMenuItem.Image")));
            this.linkGoogleDrawablesToolStripMenuItem.Name = "linkGoogleDrawablesToolStripMenuItem";
            this.linkGoogleDrawablesToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.linkGoogleDrawablesToolStripMenuItem.Text = "Link Google Drawables";
            this.linkGoogleDrawablesToolStripMenuItem.Click += new System.EventHandler(this.linkGoogleDrawablesToolStripMenuItem_Click);
            // 
            // linkAppDrawablesToolStripMenuItem
            // 
            this.linkAppDrawablesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("linkAppDrawablesToolStripMenuItem.Image")));
            this.linkAppDrawablesToolStripMenuItem.Name = "linkAppDrawablesToolStripMenuItem";
            this.linkAppDrawablesToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.linkAppDrawablesToolStripMenuItem.Text = "Link App Drawables";
            this.linkAppDrawablesToolStripMenuItem.Click += new System.EventHandler(this.linkAppDrawablesToolStripMenuItem_Click);
            // 
            // exitReplaceModeToolStripMenuItem
            // 
            this.exitReplaceModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitReplaceModeToolStripMenuItem.Image")));
            this.exitReplaceModeToolStripMenuItem.Name = "exitReplaceModeToolStripMenuItem";
            this.exitReplaceModeToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.exitReplaceModeToolStripMenuItem.Text = "Exit Replace Mode";
            this.exitReplaceModeToolStripMenuItem.Visible = false;
            this.exitReplaceModeToolStripMenuItem.Click += new System.EventHandler(this.exitReplaceModeToolStripMenuItem_Click);
            // 
            // writeChangesToFolderToolStripMenuItem
            // 
            this.writeChangesToFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("writeChangesToFolderToolStripMenuItem.Image")));
            this.writeChangesToFolderToolStripMenuItem.Name = "writeChangesToFolderToolStripMenuItem";
            this.writeChangesToFolderToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.writeChangesToFolderToolStripMenuItem.Text = "Write changes to folder";
            this.writeChangesToFolderToolStripMenuItem.Visible = false;
            this.writeChangesToFolderToolStripMenuItem.Click += new System.EventHandler(this.writeChangesToFolderToolStripMenuItem_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.cbxGoogleDrawables);
            this.pnlControls.Controls.Add(this.rbnDark);
            this.pnlControls.Controls.Add(this.rbnLight);
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Controls.Add(this.panel2);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 24);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1241, 546);
            this.pnlControls.TabIndex = 1;
            // 
            // cbxGoogleDrawables
            // 
            this.cbxGoogleDrawables.FormattingEnabled = true;
            this.cbxGoogleDrawables.Items.AddRange(new object[] {
            "drawable-hdpi",
            "drawable-mdpi",
            "drawable-xhdpi",
            "drawable-xxhdpi"});
            this.cbxGoogleDrawables.Location = new System.Drawing.Point(170, 496);
            this.cbxGoogleDrawables.Name = "cbxGoogleDrawables";
            this.cbxGoogleDrawables.Size = new System.Drawing.Size(442, 21);
            this.cbxGoogleDrawables.TabIndex = 5;
            this.cbxGoogleDrawables.SelectedIndexChanged += new System.EventHandler(this.pnlGoogleDrawables_SelectedIndexChanged);
            // 
            // rbnDark
            // 
            this.rbnDark.AutoSize = true;
            this.rbnDark.Location = new System.Drawing.Point(91, 498);
            this.rbnDark.Name = "rbnDark";
            this.rbnDark.Size = new System.Drawing.Size(73, 17);
            this.rbnDark.TabIndex = 4;
            this.rbnDark.Text = "Holo Dark";
            this.rbnDark.UseVisualStyleBackColor = true;
            // 
            // rbnLight
            // 
            this.rbnLight.AutoSize = true;
            this.rbnLight.Checked = true;
            this.rbnLight.Location = new System.Drawing.Point(12, 498);
            this.rbnLight.Name = "rbnLight";
            this.rbnLight.Size = new System.Drawing.Size(73, 17);
            this.rbnLight.TabIndex = 2;
            this.rbnLight.TabStop = true;
            this.rbnLight.Text = "Holo Light";
            this.rbnLight.UseVisualStyleBackColor = true;
            this.rbnLight.CheckedChanged += new System.EventHandler(this.rbnLight_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwGoogleDrawables);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 518);
            this.panel1.TabIndex = 9;
            // 
            // lvwGoogleDrawables
            // 
            this.lvwGoogleDrawables.Location = new System.Drawing.Point(9, 11);
            this.lvwGoogleDrawables.MultiSelect = false;
            this.lvwGoogleDrawables.Name = "lvwGoogleDrawables";
            this.lvwGoogleDrawables.Size = new System.Drawing.Size(600, 476);
            this.lvwGoogleDrawables.TabIndex = 2;
            this.lvwGoogleDrawables.UseCompatibleStateImageBehavior = false;
            this.lvwGoogleDrawables.DoubleClick += new System.EventHandler(this.lvwGoogleDrawables_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbnADark);
            this.panel2.Controls.Add(this.lvwAppDrawables);
            this.panel2.Controls.Add(this.rbnALight);
            this.panel2.Controls.Add(this.cbxAppDrawables);
            this.panel2.Location = new System.Drawing.Point(618, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 518);
            this.panel2.TabIndex = 10;
            // 
            // rbnADark
            // 
            this.rbnADark.AutoSize = true;
            this.rbnADark.Location = new System.Drawing.Point(90, 493);
            this.rbnADark.Name = "rbnADark";
            this.rbnADark.Size = new System.Drawing.Size(73, 17);
            this.rbnADark.TabIndex = 8;
            this.rbnADark.Text = "Holo Dark";
            this.rbnADark.UseVisualStyleBackColor = true;
            this.rbnADark.CheckedChanged += new System.EventHandler(this.rbnADark_CheckedChanged);
            // 
            // lvwAppDrawables
            // 
            this.lvwAppDrawables.HideSelection = false;
            this.lvwAppDrawables.Location = new System.Drawing.Point(11, 11);
            this.lvwAppDrawables.MultiSelect = false;
            this.lvwAppDrawables.Name = "lvwAppDrawables";
            this.lvwAppDrawables.Size = new System.Drawing.Size(600, 476);
            this.lvwAppDrawables.TabIndex = 3;
            this.lvwAppDrawables.UseCompatibleStateImageBehavior = false;
            this.lvwAppDrawables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvwAppDrawables_MouseClick);
            // 
            // rbnALight
            // 
            this.rbnALight.AutoSize = true;
            this.rbnALight.Checked = true;
            this.rbnALight.Location = new System.Drawing.Point(11, 493);
            this.rbnALight.Name = "rbnALight";
            this.rbnALight.Size = new System.Drawing.Size(73, 17);
            this.rbnALight.TabIndex = 7;
            this.rbnALight.TabStop = true;
            this.rbnALight.Text = "Holo Light";
            this.rbnALight.UseVisualStyleBackColor = true;
            this.rbnALight.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbxAppDrawables
            // 
            this.cbxAppDrawables.FormattingEnabled = true;
            this.cbxAppDrawables.Location = new System.Drawing.Point(169, 492);
            this.cbxAppDrawables.Name = "cbxAppDrawables";
            this.cbxAppDrawables.Size = new System.Drawing.Size(442, 21);
            this.cbxAppDrawables.TabIndex = 6;
            this.cbxAppDrawables.SelectedIndexChanged += new System.EventHandler(this.cbxAppDrawables_SelectedIndexChanged);
            // 
            // cmsListView
            // 
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSelectedToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.revertToDefaultToolStripMenuItem});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(162, 70);
            // 
            // openSelectedToolStripMenuItem
            // 
            this.openSelectedToolStripMenuItem.Name = "openSelectedToolStripMenuItem";
            this.openSelectedToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openSelectedToolStripMenuItem.Text = "Open selected";
            this.openSelectedToolStripMenuItem.Click += new System.EventHandler(this.openSelectedToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.replaceToolStripMenuItem.Text = "Replace..";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // revertToDefaultToolStripMenuItem
            // 
            this.revertToDefaultToolStripMenuItem.Name = "revertToDefaultToolStripMenuItem";
            this.revertToDefaultToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.revertToDefaultToolStripMenuItem.Text = "Revert to default";
            this.revertToDefaultToolStripMenuItem.Click += new System.EventHandler(this.revertToDefaultToolStripMenuItem_Click);
            // 
            // bgwGenerateGoogle
            // 
            this.bgwGenerateGoogle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGenerateGoogle_DoWork);
            this.bgwGenerateGoogle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGenerateGoogle_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1241, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(22, 17);
            this.lblStatus.Text = "Hi.";
            // 
            // bgwGenerateApp
            // 
            this.bgwGenerateApp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGenerateApp_DoWork);
            this.bgwGenerateApp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGenerateApp_RunWorkerCompleted);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainScreen";
            this.Text = "Holofication Nation Drawables Editor | made by +Anthe Sevenants";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cmsListView.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linkGoogleDrawablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkAppDrawablesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.ComboBox cbxGoogleDrawables;
        private System.Windows.Forms.RadioButton rbnDark;
        private System.Windows.Forms.RadioButton rbnLight;
        private System.Windows.Forms.ListView lvwAppDrawables;
        private System.Windows.Forms.ListView lvwGoogleDrawables;
        private System.Windows.Forms.ComboBox cbxAppDrawables;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem openSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitReplaceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToDefaultToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwGenerateGoogle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.ComponentModel.BackgroundWorker bgwGenerateApp;
        private System.Windows.Forms.ToolStripMenuItem writeChangesToFolderToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbnADark;
        private System.Windows.Forms.RadioButton rbnALight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

