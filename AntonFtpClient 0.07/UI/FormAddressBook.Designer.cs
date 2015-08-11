namespace Anton.FtpClientGui.UI
{
	partial class FormAddressBook
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
			this.components = new System.ComponentModel.Container();
			this.gridAddressBook = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
			this.linkConnect = new System.Windows.Forms.LinkLabel();
			this.linkBookSave = new System.Windows.Forms.LinkLabel();
			this.linkBookLoad = new System.Windows.Forms.LinkLabel();
			this.linkLoadSample = new System.Windows.Forms.LinkLabel();
			this.linkClear = new System.Windows.Forms.LinkLabel();
			this.linkEdit = new System.Windows.Forms.LinkLabel();
			this.linkNew = new System.Windows.Forms.LinkLabel();
			this.linkDelete = new System.Windows.Forms.LinkLabel();
			this.toolStripMenuItem_Header1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Header2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_AppendSampleData = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_SaveToFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_LoadFromFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Refresh = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.gridAddressBook)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridAddressBook
			// 
			this.gridAddressBook.AllowUserToAddRows = false;
			this.gridAddressBook.AllowUserToDeleteRows = false;
			this.gridAddressBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAddressBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridAddressBook.ContextMenuStrip = this.contextMenuStrip1;
			this.gridAddressBook.Location = new System.Drawing.Point(15, 48);
			this.gridAddressBook.Name = "gridAddressBook";
			this.gridAddressBook.ReadOnly = true;
			this.gridAddressBook.RowHeadersWidth = 28;
			this.gridAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridAddressBook.Size = new System.Drawing.Size(352, 389);
			this.gridAddressBook.TabIndex = 0;
			this.gridAddressBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAddressBook_CellDoubleClick);
			this.gridAddressBook.SelectionChanged += new System.EventHandler(this.gridAddressBook_SelectionChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Header1,
            this.toolStripMenuItem_Connect,
            this.toolStripMenuItem_Edit,
            this.toolStripMenuItem_Delete,
            this.toolStripMenuItem_New,
            this.toolStripSeparator2,
            this.toolStripMenuItem_Header2,
            this.toolStripMenuItem_LoadFromFile,
            this.toolStripMenuItem_SaveToFile,
            this.toolStripMenuItem_Clear,
            this.toolStripMenuItem_AppendSampleData,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Refresh});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(158, 280);
			this.contextMenuStrip1.Text = "Address Book Entry Context Menu";
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// toolStripMenuItem_Connect
			// 
			this.toolStripMenuItem_Connect.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_Connect.Name = "toolStripMenuItem_Connect";
			this.toolStripMenuItem_Connect.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Connect.Tag = "Connect to";
			this.toolStripMenuItem_Connect.Text = "Connect to";
			this.toolStripMenuItem_Connect.Click += new System.EventHandler(this.toolStripMenuItem_Connect_Click);
			// 
			// toolStripMenuItem_Edit
			// 
			this.toolStripMenuItem_Edit.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_Edit.Name = "toolStripMenuItem_Edit";
			this.toolStripMenuItem_Edit.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Edit.Tag = "Edit";
			this.toolStripMenuItem_Edit.Text = "Edit...";
			this.toolStripMenuItem_Edit.Click += new System.EventHandler(this.toolStripMenuItem_Edit_Click);
			// 
			// toolStripMenuItem_Delete
			// 
			this.toolStripMenuItem_Delete.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
			this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Delete.Tag = "Delete";
			this.toolStripMenuItem_Delete.Text = "Delete";
			this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.toolStripMenuItem_Delete_Click);
			// 
			// toolStripMenuItem_New
			// 
			this.toolStripMenuItem_New.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_New.Name = "toolStripMenuItem_New";
			this.toolStripMenuItem_New.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_New.Text = "Add new entry...";
			this.toolStripMenuItem_New.Click += new System.EventHandler(this.toolStripMenuItem_New_Click);
			// 
			// linkConnect
			// 
			this.linkConnect.AutoSize = true;
			this.linkConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkConnect.Location = new System.Drawing.Point(12, 14);
			this.linkConnect.Name = "linkConnect";
			this.linkConnect.Size = new System.Drawing.Size(69, 20);
			this.linkConnect.TabIndex = 11;
			this.linkConnect.TabStop = true;
			this.linkConnect.Text = "Connect";
			this.linkConnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkConnect_LinkClicked);
			// 
			// linkBookSave
			// 
			this.linkBookSave.AutoSize = true;
			this.linkBookSave.Location = new System.Drawing.Point(325, 26);
			this.linkBookSave.Name = "linkBookSave";
			this.linkBookSave.Size = new System.Drawing.Size(32, 13);
			this.linkBookSave.TabIndex = 20;
			this.linkBookSave.TabStop = true;
			this.linkBookSave.Text = "Save";
			this.linkBookSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBookSave_LinkClicked);
			// 
			// linkBookLoad
			// 
			this.linkBookLoad.AutoSize = true;
			this.linkBookLoad.Location = new System.Drawing.Point(327, 9);
			this.linkBookLoad.Name = "linkBookLoad";
			this.linkBookLoad.Size = new System.Drawing.Size(31, 13);
			this.linkBookLoad.TabIndex = 20;
			this.linkBookLoad.TabStop = true;
			this.linkBookLoad.Text = "Load";
			this.linkBookLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBookLoad_LinkClicked);
			// 
			// linkLoadSample
			// 
			this.linkLoadSample.AutoSize = true;
			this.linkLoadSample.Location = new System.Drawing.Point(196, 9);
			this.linkLoadSample.Name = "linkLoadSample";
			this.linkLoadSample.Size = new System.Drawing.Size(95, 13);
			this.linkLoadSample.TabIndex = 20;
			this.linkLoadSample.TabStop = true;
			this.linkLoadSample.Text = "Load Sample Data";
			this.linkLoadSample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoadSample_LinkClicked);
			// 
			// linkClear
			// 
			this.linkClear.AutoSize = true;
			this.linkClear.Location = new System.Drawing.Point(196, 26);
			this.linkClear.Name = "linkClear";
			this.linkClear.Size = new System.Drawing.Size(31, 13);
			this.linkClear.TabIndex = 20;
			this.linkClear.TabStop = true;
			this.linkClear.Text = "Clear";
			this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			// 
			// linkEdit
			// 
			this.linkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkEdit.AutoSize = true;
			this.linkEdit.Location = new System.Drawing.Point(65, 440);
			this.linkEdit.Name = "linkEdit";
			this.linkEdit.Size = new System.Drawing.Size(25, 13);
			this.linkEdit.TabIndex = 21;
			this.linkEdit.TabStop = true;
			this.linkEdit.Text = "Edit";
			this.linkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_LinkClicked);
			// 
			// linkNew
			// 
			this.linkNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkNew.AutoSize = true;
			this.linkNew.Location = new System.Drawing.Point(22, 440);
			this.linkNew.Name = "linkNew";
			this.linkNew.Size = new System.Drawing.Size(29, 13);
			this.linkNew.TabIndex = 22;
			this.linkNew.TabStop = true;
			this.linkNew.Text = "New";
			this.linkNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNew_LinkClicked);
			// 
			// linkDelete
			// 
			this.linkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkDelete.AutoSize = true;
			this.linkDelete.Location = new System.Drawing.Point(109, 440);
			this.linkDelete.Name = "linkDelete";
			this.linkDelete.Size = new System.Drawing.Size(38, 13);
			this.linkDelete.TabIndex = 22;
			this.linkDelete.TabStop = true;
			this.linkDelete.Text = "Delete";
			this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
			// 
			// toolStripMenuItem_Header1
			// 
			this.toolStripMenuItem_Header1.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.toolStripMenuItem_Header1.Name = "toolStripMenuItem_Header1";
			this.toolStripMenuItem_Header1.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Header1.Text = "Options:";
			// 
			// toolStripMenuItem_Header2
			// 
			this.toolStripMenuItem_Header2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.toolStripMenuItem_Header2.Name = "toolStripMenuItem_Header2";
			this.toolStripMenuItem_Header2.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Header2.Text = "Address Book:";
			// 
			// toolStripMenuItem_AppendSampleData
			// 
			this.toolStripMenuItem_AppendSampleData.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_AppendSampleData.Name = "toolStripMenuItem_AppendSampleData";
			this.toolStripMenuItem_AppendSampleData.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_AppendSampleData.Tag = "Connect to";
			this.toolStripMenuItem_AppendSampleData.Text = "Add sample data";
			this.toolStripMenuItem_AppendSampleData.Click += new System.EventHandler(this.toolStripMenuItem_AppendSampleData_Click);
			// 
			// toolStripMenuItem_Clear
			// 
			this.toolStripMenuItem_Clear.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_Clear.Name = "toolStripMenuItem_Clear";
			this.toolStripMenuItem_Clear.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Clear.Tag = "Connect to";
			this.toolStripMenuItem_Clear.Text = "Clear";
			this.toolStripMenuItem_Clear.Click += new System.EventHandler(this.toolStripMenuItem_Clear_Click);
			// 
			// toolStripMenuItem_SaveToFile
			// 
			this.toolStripMenuItem_SaveToFile.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_SaveToFile.Name = "toolStripMenuItem_SaveToFile";
			this.toolStripMenuItem_SaveToFile.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_SaveToFile.Tag = "Connect to";
			this.toolStripMenuItem_SaveToFile.Text = "Save to file";
			this.toolStripMenuItem_SaveToFile.Click += new System.EventHandler(this.toolStripMenuItem_SaveToFile_Click);
			// 
			// toolStripMenuItem_LoadFromFile
			// 
			this.toolStripMenuItem_LoadFromFile.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.toolStripMenuItem_LoadFromFile.Name = "toolStripMenuItem_LoadFromFile";
			this.toolStripMenuItem_LoadFromFile.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_LoadFromFile.Tag = "Connect to";
			this.toolStripMenuItem_LoadFromFile.Text = "Load from file";
			this.toolStripMenuItem_LoadFromFile.Click += new System.EventHandler(this.toolStripMenuItem_LoadFromFile_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
			// 
			// toolStripMenuItem_Refresh
			// 
			this.toolStripMenuItem_Refresh.Name = "toolStripMenuItem_Refresh";
			this.toolStripMenuItem_Refresh.Size = new System.Drawing.Size(157, 22);
			this.toolStripMenuItem_Refresh.Text = "Refresh grid";
			this.toolStripMenuItem_Refresh.Click += new System.EventHandler(this.toolStripMenuItem_Refresh_Click);
			// 
			// FormAddressBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 462);
			this.Controls.Add(this.linkDelete);
			this.Controls.Add(this.linkNew);
			this.Controls.Add(this.linkEdit);
			this.Controls.Add(this.linkBookLoad);
			this.Controls.Add(this.linkClear);
			this.Controls.Add(this.linkLoadSample);
			this.Controls.Add(this.linkBookSave);
			this.Controls.Add(this.linkConnect);
			this.Controls.Add(this.gridAddressBook);
			this.Name = "FormAddressBook";
			this.Text = "Address Book";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddressBook_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.gridAddressBook)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridAddressBook;
		private System.Windows.Forms.LinkLabel linkConnect;
		private System.Windows.Forms.LinkLabel linkBookSave;
		private System.Windows.Forms.LinkLabel linkBookLoad;
		private System.Windows.Forms.LinkLabel linkLoadSample;
		private System.Windows.Forms.LinkLabel linkClear;
		private System.Windows.Forms.LinkLabel linkEdit;
		private System.Windows.Forms.LinkLabel linkNew;
		private System.Windows.Forms.LinkLabel linkDelete;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Connect;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Edit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_New;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Header1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Header2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoadFromFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveToFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Clear;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_AppendSampleData;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Refresh;
	}
}