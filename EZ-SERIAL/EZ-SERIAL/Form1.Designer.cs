﻿namespace CommunicateWithArduino
{
	partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.terminateButton = new System.Windows.Forms.Button();
            this.comPort = new System.Windows.Forms.ComboBox();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.sendText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.receiveText = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pauseBtn);
            this.groupBox2.Controls.Add(this.refreshBtn);
            this.groupBox2.Controls.Add(this.terminateButton);
            this.groupBox2.Controls.Add(this.comPort);
            this.groupBox2.Controls.Add(this.baudRate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(16, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(301, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Manager";
            // 
            // pauseBtn
            // 
            this.pauseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pauseBtn.Location = new System.Drawing.Point(12, 123);
            this.pauseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(244, 26);
            this.pauseBtn.TabIndex = 9;
            this.pauseBtn.Text = "Pause Connection";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.refreshBtn.Location = new System.Drawing.Point(263, 22);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(1);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(25, 25);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "⭮";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // terminateButton
            // 
            this.terminateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.terminateButton.Location = new System.Drawing.Point(11, 157);
            this.terminateButton.Margin = new System.Windows.Forms.Padding(4);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(244, 26);
            this.terminateButton.TabIndex = 7;
            this.terminateButton.Text = "Terminate Connection";
            this.terminateButton.UseVisualStyleBackColor = true;
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(95, 22);
            this.comPort.Margin = new System.Windows.Forms.Padding(4);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(160, 24);
            this.comPort.TabIndex = 6;
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Location = new System.Drawing.Point(95, 53);
            this.baudRate.Margin = new System.Windows.Forms.Padding(4);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(160, 24);
            this.baudRate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud rate: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM:";
            // 
            // btnConnect
            // 
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.Location = new System.Drawing.Point(12, 89);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(244, 26);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.sendText);
            this.groupBox1.Location = new System.Drawing.Point(325, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(308, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data to send";
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.Enabled = false;
            this.sendBtn.Location = new System.Drawing.Point(200, 53);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 28);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // sendText
            // 
            this.sendText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendText.Location = new System.Drawing.Point(9, 21);
            this.sendText.Margin = new System.Windows.Forms.Padding(4);
            this.sendText.MinimumSize = new System.Drawing.Size(289, 22);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(289, 22);
            this.sendText.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.receiveText);
            this.groupBox3.Location = new System.Drawing.Point(16, 236);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(617, 440);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received data";
            // 
            // receiveText
            // 
            this.receiveText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveText.Location = new System.Drawing.Point(8, 23);
            this.receiveText.Margin = new System.Windows.Forms.Padding(4);
            this.receiveText.Multiline = true;
            this.receiveText.Name = "receiveText";
            this.receiveText.ReadOnly = true;
            this.receiveText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiveText.Size = new System.Drawing.Size(600, 408);
            this.receiveText.TabIndex = 0;
            // 
            // clrBtn
            // 
            this.clrBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clrBtn.Enabled = false;
            this.clrBtn.Location = new System.Drawing.Point(13, 678);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(68, 28);
            this.clrBtn.TabIndex = 8;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(500, 686);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(133, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Verbose Logging";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOutputToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFiletxtToolStripMenuItem});
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.saveOutputToolStripMenuItem.Text = "Save Output To:";
            // 
            // textFiletxtToolStripMenuItem
            // 
            this.textFiletxtToolStripMenuItem.Name = "textFiletxtToolStripMenuItem";
            this.textFiletxtToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.textFiletxtToolStripMenuItem.Text = "Text File (.txt)";
            this.textFiletxtToolStripMenuItem.Click += new System.EventHandler(this.textFiletxtToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 714);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(667, 761);
            this.Name = "Form1";
            this.Text = "EZ-Serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ComboBox baudRate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comPort;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button sendBtn;
		private System.Windows.Forms.TextBox sendText;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox receiveText;
		private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.ToolStripMenuItem textFiletxtToolStripMenuItem;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
    }
}

