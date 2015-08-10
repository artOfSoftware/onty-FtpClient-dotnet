namespace Anton.FtpClientGui.UI
{
	partial class FormBg
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
			this.linkStop = new System.Windows.Forms.LinkLabel();
			this.linkStart = new System.Windows.Forms.LinkLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.textOut = new System.Windows.Forms.TextBox();
			this.gridDirs = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDirs)).BeginInit();
			this.SuspendLayout();
			// 
			// linkStop
			// 
			this.linkStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkStop.AutoSize = true;
			this.linkStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkStop.Location = new System.Drawing.Point(342, 9);
			this.linkStop.Name = "linkStop";
			this.linkStop.Size = new System.Drawing.Size(43, 20);
			this.linkStop.TabIndex = 1;
			this.linkStop.TabStop = true;
			this.linkStop.Text = "Stop";
			this.linkStop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStop_LinkClicked);
			// 
			// linkStart
			// 
			this.linkStart.AutoSize = true;
			this.linkStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkStart.Location = new System.Drawing.Point(12, 9);
			this.linkStart.Name = "linkStart";
			this.linkStart.Size = new System.Drawing.Size(44, 20);
			this.linkStart.TabIndex = 1;
			this.linkStart.TabStop = true;
			this.linkStart.Text = "Start";
			this.linkStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStart_LinkClicked);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 32);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textOut);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gridDirs);
			this.splitContainer1.Size = new System.Drawing.Size(373, 541);
			this.splitContainer1.SplitterDistance = 281;
			this.splitContainer1.TabIndex = 3;
			// 
			// textOut
			// 
			this.textOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textOut.Location = new System.Drawing.Point(0, 0);
			this.textOut.Multiline = true;
			this.textOut.Name = "textOut";
			this.textOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textOut.Size = new System.Drawing.Size(373, 281);
			this.textOut.TabIndex = 1;
			// 
			// gridDirs
			// 
			this.gridDirs.AllowUserToAddRows = false;
			this.gridDirs.AllowUserToDeleteRows = false;
			this.gridDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDirs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDirs.Location = new System.Drawing.Point(0, 0);
			this.gridDirs.Name = "gridDirs";
			this.gridDirs.ReadOnly = true;
			this.gridDirs.Size = new System.Drawing.Size(373, 256);
			this.gridDirs.TabIndex = 3;
			// 
			// FormBg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 585);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.linkStart);
			this.Controls.Add(this.linkStop);
			this.Name = "FormBg";
			this.Text = "Runner...";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBg_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBg_FormClosed);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDirs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.LinkLabel linkStop;
		private System.Windows.Forms.LinkLabel linkStart;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textOut;
		private System.Windows.Forms.DataGridView gridDirs;
	}
}