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
			this.gridAddressBook = new System.Windows.Forms.DataGridView();
			this.linkConnect = new System.Windows.Forms.LinkLabel();
			this.linkBookSave = new System.Windows.Forms.LinkLabel();
			this.linkBookLoad = new System.Windows.Forms.LinkLabel();
			this.linkLoadSample = new System.Windows.Forms.LinkLabel();
			this.linkClear = new System.Windows.Forms.LinkLabel();
			this.linkEdit = new System.Windows.Forms.LinkLabel();
			this.linkNew = new System.Windows.Forms.LinkLabel();
			this.linkDelete = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.gridAddressBook)).BeginInit();
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
			this.gridAddressBook.Location = new System.Drawing.Point(15, 48);
			this.gridAddressBook.Name = "gridAddressBook";
			this.gridAddressBook.ReadOnly = true;
			this.gridAddressBook.RowHeadersWidth = 28;
			this.gridAddressBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridAddressBook.Size = new System.Drawing.Size(343, 389);
			this.gridAddressBook.TabIndex = 0;
			this.gridAddressBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAddressBook_CellDoubleClick);
			this.gridAddressBook.SelectionChanged += new System.EventHandler(this.gridAddressBook_SelectionChanged);
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
			this.linkEdit.Location = new System.Drawing.Point(56, 440);
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
			this.linkNew.Location = new System.Drawing.Point(13, 440);
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
			this.linkDelete.Location = new System.Drawing.Point(100, 440);
			this.linkDelete.Name = "linkDelete";
			this.linkDelete.Size = new System.Drawing.Size(38, 13);
			this.linkDelete.TabIndex = 22;
			this.linkDelete.TabStop = true;
			this.linkDelete.Text = "Delete";
			this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
			// 
			// FormAddressBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 462);
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
	}
}