namespace CommunicateWithArduino
{
    partial class EventHandlerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customControlComboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addControlBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTAINSBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROPERTIESBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Location = new System.Drawing.Point(205, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1424, 912);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OnClick Event (Button1)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 878);
            this.panel1.TabIndex = 1;
            // 
            // customControlComboBox
            // 
            this.customControlComboBox.FormattingEnabled = true;
            this.customControlComboBox.Location = new System.Drawing.Point(0, 15);
            this.customControlComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customControlComboBox.Name = "customControlComboBox";
            this.customControlComboBox.Size = new System.Drawing.Size(197, 24);
            this.customControlComboBox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addControlBlocksToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // addControlBlocksToolStripMenuItem
            // 
            this.addControlBlocksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialMonitorToolStripMenuItem,
            this.cONTAINSBlockToolStripMenuItem,
            this.pROPERTIESBlockToolStripMenuItem});
            this.addControlBlocksToolStripMenuItem.Name = "addControlBlocksToolStripMenuItem";
            this.addControlBlocksToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addControlBlocksToolStripMenuItem.Text = "Add Control Blocks";
            // 
            // serialMonitorToolStripMenuItem
            // 
            this.serialMonitorToolStripMenuItem.Name = "serialMonitorToolStripMenuItem";
            this.serialMonitorToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.serialMonitorToolStripMenuItem.Text = "Serial Monitor Block";
            this.serialMonitorToolStripMenuItem.Click += new System.EventHandler(this.serialMonitorToolStripMenuItem_Click);
            // 
            // cONTAINSBlockToolStripMenuItem
            // 
            this.cONTAINSBlockToolStripMenuItem.Name = "cONTAINSBlockToolStripMenuItem";
            this.cONTAINSBlockToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cONTAINSBlockToolStripMenuItem.Text = "CONTAINS Block";
            // 
            // pROPERTIESBlockToolStripMenuItem
            // 
            this.pROPERTIESBlockToolStripMenuItem.Name = "pROPERTIESBlockToolStripMenuItem";
            this.pROPERTIESBlockToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.pROPERTIESBlockToolStripMenuItem.Text = "PROPERTIES Block";
            // 
            // EventHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 938);
            this.Controls.Add(this.customControlComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EventHandlerForm";
            this.Text = "EventHandlerForm";
            this.Load += new System.EventHandler(this.EventHandlerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox customControlComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addControlBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTAINSBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROPERTIESBlockToolStripMenuItem;
    }
}