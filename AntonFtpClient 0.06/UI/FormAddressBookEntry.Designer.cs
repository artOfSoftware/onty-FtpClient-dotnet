namespace Anton.FtpClientGui.UI
{
	partial class FormAddressBookEntry
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
			this.linkSave = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.textUsername = new System.Windows.Forms.TextBox();
			this.textHostname = new System.Windows.Forms.TextBox();
			this.textComment = new System.Windows.Forms.TextBox();
			this.textIniDir = new System.Windows.Forms.TextBox();
			this.labelHeader = new System.Windows.Forms.Label();
			this.linkCancel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// linkSave
			// 
			this.linkSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkSave.AutoSize = true;
			this.linkSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkSave.Location = new System.Drawing.Point(119, 239);
			this.linkSave.Name = "linkSave";
			this.linkSave.Size = new System.Drawing.Size(45, 20);
			this.linkSave.TabIndex = 91;
			this.linkSave.TabStop = true;
			this.linkSave.Text = "Save";
			this.linkSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSave_LinkClicked);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(19, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 18);
			this.label6.TabIndex = 71;
			this.label6.Text = "Comment";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 18);
			this.label4.TabIndex = 61;
			this.label4.Text = "Initial Dir";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 18);
			this.label3.TabIndex = 51;
			this.label3.Text = "Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 18);
			this.label2.TabIndex = 31;
			this.label2.Text = "Login User Name";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Title";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 18);
			this.label1.TabIndex = 21;
			this.label1.Text = "Server Host Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textPassword
			// 
			this.textPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textPassword.Location = new System.Drawing.Point(119, 122);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '#';
			this.textPassword.Size = new System.Drawing.Size(245, 20);
			this.textPassword.TabIndex = 52;
			this.textPassword.UseSystemPasswordChar = true;
			// 
			// textTitle
			// 
			this.textTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textTitle.Location = new System.Drawing.Point(119, 42);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(245, 20);
			this.textTitle.TabIndex = 12;
			// 
			// textUsername
			// 
			this.textUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textUsername.Location = new System.Drawing.Point(119, 95);
			this.textUsername.Name = "textUsername";
			this.textUsername.Size = new System.Drawing.Size(245, 20);
			this.textUsername.TabIndex = 32;
			// 
			// textHostname
			// 
			this.textHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textHostname.Location = new System.Drawing.Point(119, 68);
			this.textHostname.Name = "textHostname";
			this.textHostname.Size = new System.Drawing.Size(245, 20);
			this.textHostname.TabIndex = 22;
			// 
			// textComment
			// 
			this.textComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textComment.Location = new System.Drawing.Point(119, 174);
			this.textComment.Multiline = true;
			this.textComment.Name = "textComment";
			this.textComment.Size = new System.Drawing.Size(245, 61);
			this.textComment.TabIndex = 73;
			// 
			// textIniDir
			// 
			this.textIniDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textIniDir.Location = new System.Drawing.Point(119, 148);
			this.textIniDir.Name = "textIniDir";
			this.textIniDir.Size = new System.Drawing.Size(245, 20);
			this.textIniDir.TabIndex = 62;
			// 
			// labelHeader
			// 
			this.labelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHeader.Location = new System.Drawing.Point(12, 9);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Size = new System.Drawing.Size(352, 23);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "[Header]";
			// 
			// linkCancel
			// 
			this.linkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkCancel.AutoSize = true;
			this.linkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkCancel.Location = new System.Drawing.Point(185, 239);
			this.linkCancel.Name = "linkCancel";
			this.linkCancel.Size = new System.Drawing.Size(58, 20);
			this.linkCancel.TabIndex = 92;
			this.linkCancel.TabStop = true;
			this.linkCancel.Text = "Cancel";
			this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCancel_LinkClicked);
			// 
			// FormAddressBookEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 279);
			this.Controls.Add(this.labelHeader);
			this.Controls.Add(this.linkCancel);
			this.Controls.Add(this.linkSave);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textTitle);
			this.Controls.Add(this.textUsername);
			this.Controls.Add(this.textHostname);
			this.Controls.Add(this.textComment);
			this.Controls.Add(this.textIniDir);
			this.Name = "FormAddressBookEntry";
			this.Text = "AddressBook Entry";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkSave;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textPassword;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.TextBox textUsername;
		private System.Windows.Forms.TextBox textHostname;
		private System.Windows.Forms.TextBox textComment;
		private System.Windows.Forms.TextBox textIniDir;
		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.LinkLabel linkCancel;
	}
}