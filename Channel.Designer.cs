namespace MixInStyle
{
    partial class Channel
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
            this.inputSelector = new System.Windows.Forms.ComboBox();
            this.outputSelector = new System.Windows.Forms.ComboBox();
            this.Index = new System.Windows.Forms.Label();
            this.volumeBar = new MixInStyle.Core.VProgressBar();
            this.recordToggle = new MixInStyle.Core.Toogle();
            this.volKnob = new MixInStyle.Core.KnobControl();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputSelector
            // 
            this.inputSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.inputSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSelector.DropDownWidth = 300;
            this.inputSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputSelector.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputSelector.ForeColor = System.Drawing.Color.White;
            this.inputSelector.FormattingEnabled = true;
            this.inputSelector.Location = new System.Drawing.Point(3, 317);
            this.inputSelector.Name = "inputSelector";
            this.inputSelector.Size = new System.Drawing.Size(43, 22);
            this.inputSelector.TabIndex = 1;
            this.inputSelector.TabStop = false;
            this.inputSelector.SelectedIndexChanged += new System.EventHandler(this.inputSelector_SelectedIndexChanged);
            // 
            // outputSelector
            // 
            this.outputSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.outputSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputSelector.DropDownWidth = 300;
            this.outputSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outputSelector.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputSelector.ForeColor = System.Drawing.Color.White;
            this.outputSelector.FormattingEnabled = true;
            this.outputSelector.Location = new System.Drawing.Point(3, 345);
            this.outputSelector.Name = "outputSelector";
            this.outputSelector.Size = new System.Drawing.Size(43, 22);
            this.outputSelector.TabIndex = 1;
            this.outputSelector.TabStop = false;
            this.outputSelector.SelectedIndexChanged += new System.EventHandler(this.outputSelector_SelectedIndexChanged);
            // 
            // Index
            // 
            this.Index.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Index.BackColor = System.Drawing.Color.Transparent;
            this.Index.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Index.ForeColor = System.Drawing.SystemColors.Control;
            this.Index.Location = new System.Drawing.Point(6, 372);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(38, 17);
            this.Index.TabIndex = 2;
            this.Index.Text = "0";
            this.Index.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.volumeBar.Location = new System.Drawing.Point(6, 36);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(38, 275);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.Value = 0;
            // 
            // recordToggle
            // 
            this.recordToggle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recordToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordToggle.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recordToggle.ForeColor = System.Drawing.Color.Red;
            this.recordToggle.Location = new System.Drawing.Point(14, 7);
            this.recordToggle.Name = "recordToggle";
            this.recordToggle.Size = new System.Drawing.Size(23, 23);
            this.recordToggle.TabIndex = 4;
            this.recordToggle.Text = "R";
            this.recordToggle.UseVisualStyleBackColor = true;
            this.recordToggle.Click += new System.EventHandler(this.recordToggle_Click);
            // 
            // volKnob
            // 
            this.volKnob.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volKnob.EndAngle = 405F;
            this.volKnob.Font = new System.Drawing.Font("Segoe UI", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volKnob.ImeMode = System.Windows.Forms.ImeMode.On;
            this.volKnob.KnobBackColor = System.Drawing.Color.White;
            this.volKnob.KnobPointerStyle = MixInStyle.Core.KnobControl.KnobPointerStyles.line;
            this.volKnob.LargeChange = 5;
            this.volKnob.Location = new System.Drawing.Point(11, 394);
            this.volKnob.Maximum = 100;
            this.volKnob.Minimum = 0;
            this.volKnob.Name = "volKnob";
            this.volKnob.PointerColor = System.Drawing.Color.MediumSeaGreen;
            this.volKnob.ScaleColor = System.Drawing.SystemColors.Control;
            this.volKnob.ScaleDivisions = 11;
            this.volKnob.ScaleFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volKnob.ScaleSubDivisions = 4;
            this.volKnob.ShowLargeScale = false;
            this.volKnob.ShowSmallScale = false;
            this.volKnob.Size = new System.Drawing.Size(26, 26);
            this.volKnob.SmallChange = 1;
            this.volKnob.StartAngle = 135F;
            this.volKnob.TabIndex = 5;
            this.volKnob.TabStop = false;
            this.volKnob.Value = 50;
            this.volKnob.ValueChanged += new MixInStyle.Core.ValueChangedEventHandler(this.volKnob_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Volume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.volKnob);
            this.Controls.Add(this.recordToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.outputSelector);
            this.Controls.Add(this.inputSelector);
            this.Controls.Add(this.volumeBar);
            this.Name = "Channel";
            this.Size = new System.Drawing.Size(49, 446);
            this.ResumeLayout(false);

        }

        #endregion
        internal Label Index;
        internal Label label2;
        internal Core.Toogle recordToggle;
        internal ComboBox inputSelector;
        internal ComboBox outputSelector;
        internal Core.VProgressBar volumeBar;
        internal Core.KnobControl volKnob;
    }
}
