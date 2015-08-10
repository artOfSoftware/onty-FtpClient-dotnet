namespace Anton.FtpClientGui.UI
{
	partial class FormFtpClient
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFtpClient));
			this.textOut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.labelCwd = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem_AddressBook = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_AnalyzeSiteUsage = new System.Windows.Forms.ToolStripMenuItem();
			this.labelHostName = new System.Windows.Forms.Label();
			this.linkCdUp = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeDirs = new System.Windows.Forms.TreeView();
			this.gridItems = new System.Windows.Forms.DataGridView();
			this.menuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
			this.SuspendLayout();
			// 
			// textOut
			// 
			this.textOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.textOut.Location = new System.Drawing.Point(12, 433);
			this.textOut.Multiline = true;
			this.textOut.Name = "textOut";
			this.textOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textOut.Size = new System.Drawing.Size(723, 80);
			this.textOut.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Server Host:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelCwd
			// 
			this.labelCwd.Location = new System.Drawing.Point(128, 56);
			this.labelCwd.Name = "labelCwd";
			this.labelCwd.Size = new System.Drawing.Size(604, 13);
			this.labelCwd.TabIndex = 11;
			this.labelCwd.Text = "[cwd]";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Current dir:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_AddressBook,
            this.toolStripMenuItem_AnalyzeSiteUsage});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(747, 24);
			this.menuMain.TabIndex = 1;
			this.menuMain.Text = "Main Menu";
			// 
			// toolStripMenuItem_AddressBook
			// 
			this.toolStripMenuItem_AddressBook.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_AddressBook.Image")));
			this.toolStripMenuItem_AddressBook.Name = "toolStripMenuItem_AddressBook";
			this.toolStripMenuItem_AddressBook.Size = new System.Drawing.Size(100, 20);
			this.toolStripMenuItem_AddressBook.Text = "Address Book";
			this.toolStripMenuItem_AddressBook.Click += new System.EventHandler(this.toolStripMenuItem_AddressBook_Click);
			// 
			// toolStripMenuItem_AnalyzeSiteUsage
			// 
			this.toolStripMenuItem_AnalyzeSiteUsage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_AnalyzeSiteUsage.Image")));
			this.toolStripMenuItem_AnalyzeSiteUsage.Name = "toolStripMenuItem_AnalyzeSiteUsage";
			this.toolStripMenuItem_AnalyzeSiteUsage.Size = new System.Drawing.Size(127, 20);
			this.toolStripMenuItem_AnalyzeSiteUsage.Text = "Analyze Site Usage";
			this.toolStripMenuItem_AnalyzeSiteUsage.Click += new System.EventHandler(this.toolStripMenuItem_AnalyzeSiteUsage_Click);
			// 
			// labelHostName
			// 
			this.labelHostName.Location = new System.Drawing.Point(128, 33);
			this.labelHostName.Name = "labelHostName";
			this.labelHostName.Size = new System.Drawing.Size(303, 13);
			this.labelHostName.TabIndex = 11;
			this.labelHostName.Text = "[host name]";
			// 
			// linkCdUp
			// 
			this.linkCdUp.AutoSize = true;
			this.linkCdUp.Location = new System.Drawing.Point(228, 84);
			this.linkCdUp.Name = "linkCdUp";
			this.linkCdUp.Size = new System.Drawing.Size(37, 13);
			this.linkCdUp.TabIndex = 13;
			this.linkCdUp.TabStop = true;
			this.linkCdUp.Text = "Up Dir";
			this.linkCdUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCdUp_LinkClicked);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 413);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Message Log:";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 100);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeDirs);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gridItems);
			this.splitContainer1.Size = new System.Drawing.Size(723, 310);
			this.splitContainer1.SplitterDistance = 215;
			this.splitContainer1.TabIndex = 16;
			// 
			// treeDirs
			// 
			this.treeDirs.BackColor = System.Drawing.Color.Silver;
			this.treeDirs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeDirs.HideSelection = false;
			this.treeDirs.Location = new System.Drawing.Point(0, 0);
			this.treeDirs.Name = "treeDirs";
			this.treeDirs.Size = new System.Drawing.Size(215, 310);
			this.treeDirs.TabIndex = 15;
			this.treeDirs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDirs_AfterSelect);
			// 
			// gridItems
			// 
			this.gridItems.AllowUserToAddRows = false;
			this.gridItems.AllowUserToDeleteRows = false;
			this.gridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridItems.Location = new System.Drawing.Point(0, 0);
			this.gridItems.Name = "gridItems";
			this.gridItems.ReadOnly = true;
			this.gridItems.RowHeadersWidth = 28;
			this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridItems.Size = new System.Drawing.Size(504, 310);
			this.gridItems.TabIndex = 3;
			this.gridItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItems_CellDoubleClick);
			// 
			// FormFtpClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 525);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkCdUp);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelHostName);
			this.Controls.Add(this.labelCwd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textOut);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "FormFtpClient";
			this.Text = "[set at runtime via code]";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textOut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCwd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AddressBook;
		private System.Windows.Forms.Label labelHostName;
		private System.Windows.Forms.LinkLabel linkCdUp;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeDirs;
		private System.Windows.Forms.DataGridView gridItems;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AnalyzeSiteUsage;
	}
}

