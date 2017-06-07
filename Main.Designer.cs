namespace IsoMetall_calcul
{
    partial class Main
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
            this.numericUpDownSpeedLine = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSheetWidth = new System.Windows.Forms.NumericUpDown();
            this.timerGlobal = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLengthSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonPowerOn = new System.Windows.Forms.Button();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheetWidth)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownSpeedLine
            // 
            this.numericUpDownSpeedLine.DecimalPlaces = 1;
            this.numericUpDownSpeedLine.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeedLine.Location = new System.Drawing.Point(12, 99);
            this.numericUpDownSpeedLine.Name = "numericUpDownSpeedLine";
            this.numericUpDownSpeedLine.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownSpeedLine.TabIndex = 0;
            this.numericUpDownSpeedLine.ValueChanged += new System.EventHandler(this.numericUpDownSpeedLine_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "m/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largeur produit fini:";
            // 
            // numericUpDownSheetWidth
            // 
            this.numericUpDownSheetWidth.Location = new System.Drawing.Point(12, 160);
            this.numericUpDownSheetWidth.Name = "numericUpDownSheetWidth";
            this.numericUpDownSheetWidth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSheetWidth.TabIndex = 2;
            this.numericUpDownSheetWidth.ValueChanged += new System.EventHandler(this.numericUpDownSheetWidth_ValueChanged);
            // 
            // timerGlobal
            // 
            this.timerGlobal.Tick += new System.EventHandler(this.timerGlobal_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLengthSum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLengthSum
            // 
            this.toolStripStatusLabelLengthSum.Name = "toolStripStatusLabelLengthSum";
            this.toolStripStatusLabelLengthSum.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabelLengthSum.Text = "-";
            // 
            // buttonPowerOn
            // 
            this.buttonPowerOn.Location = new System.Drawing.Point(12, 15);
            this.buttonPowerOn.Name = "buttonPowerOn";
            this.buttonPowerOn.Size = new System.Drawing.Size(94, 78);
            this.buttonPowerOn.TabIndex = 7;
            this.buttonPowerOn.Text = "Go";
            this.buttonPowerOn.UseVisualStyleBackColor = true;
            this.buttonPowerOn.Click += new System.EventHandler(this.buttonPowerOn_Click);
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.Location = new System.Drawing.Point(112, 44);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(55, 49);
            this.buttonPowerOff.TabIndex = 8;
            this.buttonPowerOff.Text = "Stop";
            this.buttonPowerOff.UseVisualStyleBackColor = true;
            this.buttonPowerOff.Click += new System.EventHandler(this.buttonPowerOff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hauteur produit fini:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPowerOff);
            this.Controls.Add(this.buttonPowerOn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownSheetWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSpeedLine);
            this.Location = new System.Drawing.Point(40, 40);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheetWidth)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSpeedLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSheetWidth;
        private System.Windows.Forms.Timer timerGlobal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLengthSum;
        private System.Windows.Forms.Button buttonPowerOn;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.Label label3;
    }
}