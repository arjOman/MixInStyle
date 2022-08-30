namespace MixInStyle
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.monoRD = new System.Windows.Forms.RadioButton();
            this.recordGroup = new System.Windows.Forms.GroupBox();
            this.buffermsUpDown = new System.Windows.Forms.NumericUpDown();
            this.stereoRD = new System.Windows.Forms.RadioButton();
            this.bitsCmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.smplCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thresholdBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bpsCmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.coffee = new System.Windows.Forms.PictureBox();
            this.recordGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buffermsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preferences";
            // 
            // monoRD
            // 
            this.monoRD.AutoSize = true;
            this.monoRD.Location = new System.Drawing.Point(94, 25);
            this.monoRD.Name = "monoRD";
            this.monoRD.Size = new System.Drawing.Size(66, 23);
            this.monoRD.TabIndex = 7;
            this.monoRD.TabStop = true;
            this.monoRD.Text = "Mono";
            this.monoRD.UseVisualStyleBackColor = true;
            this.monoRD.CheckedChanged += new System.EventHandler(this.monoRD_CheckedChanged);
            // 
            // recordGroup
            // 
            this.recordGroup.Controls.Add(this.buffermsUpDown);
            this.recordGroup.Controls.Add(this.stereoRD);
            this.recordGroup.Controls.Add(this.monoRD);
            this.recordGroup.Controls.Add(this.bitsCmb);
            this.recordGroup.Controls.Add(this.label7);
            this.recordGroup.Controls.Add(this.smplCmb);
            this.recordGroup.Controls.Add(this.label5);
            this.recordGroup.Controls.Add(this.label6);
            this.recordGroup.Controls.Add(this.label2);
            this.recordGroup.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.recordGroup.Location = new System.Drawing.Point(25, 83);
            this.recordGroup.Name = "recordGroup";
            this.recordGroup.Size = new System.Drawing.Size(289, 182);
            this.recordGroup.TabIndex = 8;
            this.recordGroup.TabStop = false;
            this.recordGroup.Text = "Input";
            // 
            // buffermsUpDown
            // 
            this.buffermsUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.buffermsUpDown.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buffermsUpDown.Location = new System.Drawing.Point(124, 139);
            this.buffermsUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.buffermsUpDown.Name = "buffermsUpDown";
            this.buffermsUpDown.Size = new System.Drawing.Size(147, 25);
            this.buffermsUpDown.TabIndex = 11;
            this.buffermsUpDown.ValueChanged += new System.EventHandler(this.buffermsUpDown_ValueChanged);
            // 
            // stereoRD
            // 
            this.stereoRD.AutoSize = true;
            this.stereoRD.Location = new System.Drawing.Point(166, 25);
            this.stereoRD.Name = "stereoRD";
            this.stereoRD.Size = new System.Drawing.Size(76, 23);
            this.stereoRD.TabIndex = 7;
            this.stereoRD.TabStop = true;
            this.stereoRD.Text = "Stereo";
            this.stereoRD.UseVisualStyleBackColor = true;
            this.stereoRD.CheckedChanged += new System.EventHandler(this.stereoRD_CheckedChanged);
            // 
            // bitsCmb
            // 
            this.bitsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitsCmb.FormattingEnabled = true;
            this.bitsCmb.Items.AddRange(new object[] {
            "16",
            "32"});
            this.bitsCmb.Location = new System.Drawing.Point(124, 100);
            this.bitsCmb.Name = "bitsCmb";
            this.bitsCmb.Size = new System.Drawing.Size(147, 27);
            this.bitsCmb.TabIndex = 10;
            this.bitsCmb.SelectedIndexChanged += new System.EventHandler(this.bitsCmb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(13, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Buffer Ms";
            // 
            // smplCmb
            // 
            this.smplCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smplCmb.FormattingEnabled = true;
            this.smplCmb.Items.AddRange(new object[] {
            "8000",
            "11025",
            "16000",
            "22050",
            "44100",
            "48000",
            "88200",
            "96000",
            "176400",
            "19200",
            "352800",
            "384000"});
            this.smplCmb.Location = new System.Drawing.Point(124, 61);
            this.smplCmb.Name = "smplCmb";
            this.smplCmb.Size = new System.Drawing.Size(147, 27);
            this.smplCmb.TabIndex = 10;
            this.smplCmb.SelectedIndexChanged += new System.EventHandler(this.smplCmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sampling Rate";
            // 
            // thresholdBox
            // 
            this.thresholdBox.BackColor = System.Drawing.SystemColors.Control;
            this.thresholdBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thresholdBox.Location = new System.Drawing.Point(149, 321);
            this.thresholdBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.thresholdBox.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.thresholdBox.Name = "thresholdBox";
            this.thresholdBox.Size = new System.Drawing.Size(147, 25);
            this.thresholdBox.TabIndex = 11;
            this.thresholdBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.thresholdBox.ValueChanged += new System.EventHandler(this.thresholdBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(38, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Threshold";
            // 
            // bpsCmb
            // 
            this.bpsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bpsCmb.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpsCmb.FormattingEnabled = true;
            this.bpsCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6"});
            this.bpsCmb.Location = new System.Drawing.Point(149, 282);
            this.bpsCmb.Name = "bpsCmb";
            this.bpsCmb.Size = new System.Drawing.Size(147, 27);
            this.bpsCmb.TabIndex = 10;
            this.bpsCmb.SelectedIndexChanged += new System.EventHandler(this.bpsCmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(38, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "B/Sample";
            // 
            // coffee
            // 
            this.coffee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coffee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coffee.Image = ((System.Drawing.Image)(resources.GetObject("coffee.Image")));
            this.coffee.Location = new System.Drawing.Point(99, 372);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(144, 35);
            this.coffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coffee.TabIndex = 12;
            this.coffee.TabStop = false;
            this.coffee.Click += new System.EventHandler(this.coffee_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.bpsCmb);
            this.Controls.Add(this.thresholdBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recordGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.recordGroup.ResumeLayout(false);
            this.recordGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buffermsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private RadioButton monoRD;
        private GroupBox recordGroup;
        private RadioButton stereoRD;
        private Label label2;
        private ComboBox smplCmb;
        private NumericUpDown thresholdBox;
        private Label label3;
        private ComboBox bpsCmb;
        private Label label4;
        private Label label5;
        private ComboBox bitsCmb;
        private Label label6;
        private NumericUpDown buffermsUpDown;
        private Label label7;
        private PictureBox coffee;
    }
}