namespace CommunicateWithArduino
{
    partial class SerialMonitorBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedPortComboBox = new System.Windows.Forms.ComboBox();
            this.selectedPortLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputRadioButton = new System.Windows.Forms.RadioButton();
            this.OutputRadioButton = new System.Windows.Forms.RadioButton();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.baudRateLabel);
            this.panel1.Controls.Add(this.baudRateComboBox);
            this.panel1.Controls.Add(this.OutputRadioButton);
            this.panel1.Controls.Add(this.InputRadioButton);
            this.panel1.Controls.Add(this.selectedPortLabel);
            this.panel1.Controls.Add(this.selectedPortComboBox);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 233);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 61);
            this.panel2.TabIndex = 1;
            // 
            // selectedPortComboBox
            // 
            this.selectedPortComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectedPortComboBox.FormattingEnabled = true;
            this.selectedPortComboBox.Location = new System.Drawing.Point(208, 31);
            this.selectedPortComboBox.Name = "selectedPortComboBox";
            this.selectedPortComboBox.Size = new System.Drawing.Size(121, 24);
            this.selectedPortComboBox.TabIndex = 0;
            // 
            // selectedPortLabel
            // 
            this.selectedPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectedPortLabel.AutoSize = true;
            this.selectedPortLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPortLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedPortLabel.Location = new System.Drawing.Point(42, 31);
            this.selectedPortLabel.Name = "selectedPortLabel";
            this.selectedPortLabel.Size = new System.Drawing.Size(160, 26);
            this.selectedPortLabel.TabIndex = 1;
            this.selectedPortLabel.Text = "Selected Port: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial Monitor Control Block";
            // 
            // InputRadioButton
            // 
            this.InputRadioButton.AutoSize = true;
            this.InputRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InputRadioButton.Location = new System.Drawing.Point(3, 156);
            this.InputRadioButton.Name = "InputRadioButton";
            this.InputRadioButton.Size = new System.Drawing.Size(56, 20);
            this.InputRadioButton.TabIndex = 2;
            this.InputRadioButton.TabStop = true;
            this.InputRadioButton.Text = "Input";
            this.InputRadioButton.UseVisualStyleBackColor = true;
            // 
            // OutputRadioButton
            // 
            this.OutputRadioButton.AutoSize = true;
            this.OutputRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutputRadioButton.Location = new System.Drawing.Point(302, 156);
            this.OutputRadioButton.Name = "OutputRadioButton";
            this.OutputRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OutputRadioButton.Size = new System.Drawing.Size(66, 20);
            this.OutputRadioButton.TabIndex = 3;
            this.OutputRadioButton.TabStop = true;
            this.OutputRadioButton.Text = "Output";
            this.OutputRadioButton.UseVisualStyleBackColor = true;
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.baudRateLabel.Location = new System.Drawing.Point(42, 76);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(125, 26);
            this.baudRateLabel.TabIndex = 5;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(208, 76);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.baudRateComboBox.TabIndex = 4;
            // 
            // SerialMonitorBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SerialMonitorBlock";
            this.Size = new System.Drawing.Size(377, 291);
            this.Load += new System.EventHandler(this.SerialMonitorBlock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedPortLabel;
        private System.Windows.Forms.ComboBox selectedPortComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OutputRadioButton;
        private System.Windows.Forms.RadioButton InputRadioButton;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox baudRateComboBox;
    }
}
