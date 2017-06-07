namespace IsoMetall_calcul
{
    partial class Glue
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
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.buttonMoveOn = new System.Windows.Forms.Button();
            this.timerProccess = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSprayGrammage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpraySize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSpeedLine = new System.Windows.Forms.Label();
            this.labelSprayUse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCycleDuration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSprayUseSum = new System.Windows.Forms.Label();
            this.numericUpDownAxeXMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownAxeXMin = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.labelWidthSizeSpray = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAxeDuration = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonGlue = new System.Windows.Forms.Button();
            this.buttonRinse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAxeXSpeed = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.numericUpDownRinsePosition = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownResetPosition = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownRinseDuration = new System.Windows.Forms.NumericUpDown();
            this.labelRinseDuration = new System.Windows.Forms.Label();
            this.progressBarLineSpeed = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSprayGrammage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxeXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxeXMin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRinsePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResetPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRinseDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Location = new System.Drawing.Point(10, 435);
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(721, 45);
            this.trackBarPosition.TabIndex = 0;
            this.trackBarPosition.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // buttonMoveOn
            // 
            this.buttonMoveOn.Location = new System.Drawing.Point(289, 354);
            this.buttonMoveOn.Name = "buttonMoveOn";
            this.buttonMoveOn.Size = new System.Drawing.Size(80, 59);
            this.buttonMoveOn.TabIndex = 1;
            this.buttonMoveOn.Text = "Mouvement";
            this.buttonMoveOn.UseVisualStyleBackColor = true;
            this.buttonMoveOn.Click += new System.EventHandler(this.buttonMoveOn_Click);
            // 
            // timerProccess
            // 
            this.timerProccess.Tick += new System.EventHandler(this.timerProccess_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grammage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largeur de spray";
            // 
            // numericUpDownSprayGrammage
            // 
            this.numericUpDownSprayGrammage.Location = new System.Drawing.Point(461, 25);
            this.numericUpDownSprayGrammage.Name = "numericUpDownSprayGrammage";
            this.numericUpDownSprayGrammage.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSprayGrammage.TabIndex = 4;
            this.numericUpDownSprayGrammage.ValueChanged += new System.EventHandler(this.numericUpDownSprayGrammage_ValueChanged);
            // 
            // numericUpDownSpraySize
            // 
            this.numericUpDownSpraySize.Location = new System.Drawing.Point(461, 73);
            this.numericUpDownSpraySize.Name = "numericUpDownSpraySize";
            this.numericUpDownSpraySize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpraySize.TabIndex = 5;
            this.numericUpDownSpraySize.ValueChanged += new System.EventHandler(this.numericUpDownSpraySize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vitesse de ligne:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consommation réelle:";
            // 
            // labelSpeedLine
            // 
            this.labelSpeedLine.AutoSize = true;
            this.labelSpeedLine.Location = new System.Drawing.Point(146, 20);
            this.labelSpeedLine.Name = "labelSpeedLine";
            this.labelSpeedLine.Size = new System.Drawing.Size(10, 13);
            this.labelSpeedLine.TabIndex = 8;
            this.labelSpeedLine.Text = "-";
            // 
            // labelSprayUse
            // 
            this.labelSprayUse.AutoSize = true;
            this.labelSprayUse.Location = new System.Drawing.Point(149, 87);
            this.labelSprayUse.Name = "labelSprayUse";
            this.labelSprayUse.Size = new System.Drawing.Size(10, 13);
            this.labelSprayUse.TabIndex = 9;
            this.labelSprayUse.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durée de cycle:";
            // 
            // labelCycleDuration
            // 
            this.labelCycleDuration.AutoSize = true;
            this.labelCycleDuration.Location = new System.Drawing.Point(148, 151);
            this.labelCycleDuration.Name = "labelCycleDuration";
            this.labelCycleDuration.Size = new System.Drawing.Size(10, 13);
            this.labelCycleDuration.TabIndex = 10;
            this.labelCycleDuration.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Consommation totale:";
            // 
            // labelSprayUseSum
            // 
            this.labelSprayUseSum.AutoSize = true;
            this.labelSprayUseSum.Location = new System.Drawing.Point(149, 121);
            this.labelSprayUseSum.Name = "labelSprayUseSum";
            this.labelSprayUseSum.Size = new System.Drawing.Size(10, 13);
            this.labelSprayUseSum.TabIndex = 12;
            this.labelSprayUseSum.Text = "-";
            // 
            // numericUpDownAxeXMax
            // 
            this.numericUpDownAxeXMax.Location = new System.Drawing.Point(648, 393);
            this.numericUpDownAxeXMax.Name = "numericUpDownAxeXMax";
            this.numericUpDownAxeXMax.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownAxeXMax.TabIndex = 15;
            this.numericUpDownAxeXMax.ValueChanged += new System.EventHandler(this.numericUpDownAxeXMax_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max (Point zéro)";
            // 
            // numericUpDownAxeXMin
            // 
            this.numericUpDownAxeXMin.Location = new System.Drawing.Point(16, 393);
            this.numericUpDownAxeXMin.Name = "numericUpDownAxeXMin";
            this.numericUpDownAxeXMin.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownAxeXMin.TabIndex = 17;
            this.numericUpDownAxeXMin.ValueChanged += new System.EventHandler(this.numericUpDownAxeXMin_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Min";
            // 
            // labelWidthSizeSpray
            // 
            this.labelWidthSizeSpray.AutoSize = true;
            this.labelWidthSizeSpray.Location = new System.Drawing.Point(146, 52);
            this.labelWidthSizeSpray.Name = "labelWidthSizeSpray";
            this.labelWidthSizeSpray.Size = new System.Drawing.Size(10, 13);
            this.labelWidthSizeSpray.TabIndex = 19;
            this.labelWidthSizeSpray.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Largeur de projection:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAxeDuration});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(743, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelAxeDuration
            // 
            this.toolStripStatusLabelAxeDuration.Name = "toolStripStatusLabelAxeDuration";
            this.toolStripStatusLabelAxeDuration.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabelAxeDuration.Text = "-";
            // 
            // buttonGlue
            // 
            this.buttonGlue.Location = new System.Drawing.Point(186, 354);
            this.buttonGlue.Name = "buttonGlue";
            this.buttonGlue.Size = new System.Drawing.Size(80, 59);
            this.buttonGlue.TabIndex = 25;
            this.buttonGlue.Text = "Colle";
            this.buttonGlue.UseVisualStyleBackColor = true;
            this.buttonGlue.Click += new System.EventHandler(this.buttonGlue_Click);
            // 
            // buttonRinse
            // 
            this.buttonRinse.Location = new System.Drawing.Point(484, 388);
            this.buttonRinse.Name = "buttonRinse";
            this.buttonRinse.Size = new System.Drawing.Size(80, 26);
            this.buttonRinse.TabIndex = 26;
            this.buttonRinse.Text = "Rinçage";
            this.buttonRinse.UseVisualStyleBackColor = true;
            this.buttonRinse.Click += new System.EventHandler(this.buttonRinse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Vitesse:";
            // 
            // labelAxeXSpeed
            // 
            this.labelAxeXSpeed.AutoSize = true;
            this.labelAxeXSpeed.Location = new System.Drawing.Point(149, 179);
            this.labelAxeXSpeed.Name = "labelAxeXSpeed";
            this.labelAxeXSpeed.Size = new System.Drawing.Size(10, 13);
            this.labelAxeXSpeed.TabIndex = 27;
            this.labelAxeXSpeed.Text = "-";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(390, 388);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 26);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // numericUpDownRinsePosition
            // 
            this.numericUpDownRinsePosition.Location = new System.Drawing.Point(603, 73);
            this.numericUpDownRinsePosition.Name = "numericUpDownRinsePosition";
            this.numericUpDownRinsePosition.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRinsePosition.TabIndex = 31;
            this.numericUpDownRinsePosition.ValueChanged += new System.EventHandler(this.numericUpDownRinsePosition_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Position rinçage";
            // 
            // numericUpDownResetPosition
            // 
            this.numericUpDownResetPosition.Location = new System.Drawing.Point(603, 25);
            this.numericUpDownResetPosition.Name = "numericUpDownResetPosition";
            this.numericUpDownResetPosition.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownResetPosition.TabIndex = 33;
            this.numericUpDownResetPosition.ValueChanged += new System.EventHandler(this.numericUpDownResetPosition_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(600, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Position reset";
            // 
            // numericUpDownRinseDuration
            // 
            this.numericUpDownRinseDuration.Location = new System.Drawing.Point(603, 122);
            this.numericUpDownRinseDuration.Name = "numericUpDownRinseDuration";
            this.numericUpDownRinseDuration.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRinseDuration.TabIndex = 35;
            this.numericUpDownRinseDuration.ValueChanged += new System.EventHandler(this.numericUpDownRinseDuration_ValueChanged);
            // 
            // labelRinseDuration
            // 
            this.labelRinseDuration.AutoSize = true;
            this.labelRinseDuration.Location = new System.Drawing.Point(600, 106);
            this.labelRinseDuration.Name = "labelRinseDuration";
            this.labelRinseDuration.Size = new System.Drawing.Size(74, 13);
            this.labelRinseDuration.TabIndex = 34;
            this.labelRinseDuration.Text = "Durée rinçage";
            // 
            // progressBarLineSpeed
            // 
            this.progressBarLineSpeed.Location = new System.Drawing.Point(461, 122);
            this.progressBarLineSpeed.Name = "progressBarLineSpeed";
            this.progressBarLineSpeed.Size = new System.Drawing.Size(120, 20);
            this.progressBarLineSpeed.TabIndex = 36;
            // 
            // Glue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 517);
            this.Controls.Add(this.progressBarLineSpeed);
            this.Controls.Add(this.numericUpDownRinseDuration);
            this.Controls.Add(this.labelRinseDuration);
            this.Controls.Add(this.numericUpDownResetPosition);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownRinsePosition);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelAxeXSpeed);
            this.Controls.Add(this.buttonRinse);
            this.Controls.Add(this.buttonGlue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelWidthSizeSpray);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownAxeXMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownAxeXMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSprayUseSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCycleDuration);
            this.Controls.Add(this.labelSprayUse);
            this.Controls.Add(this.labelSpeedLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSpraySize);
            this.Controls.Add(this.numericUpDownSprayGrammage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMoveOn);
            this.Controls.Add(this.trackBarPosition);
            this.Name = "Glue";
            this.Text = "Glue";
            this.Load += new System.EventHandler(this.Glue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSprayGrammage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxeXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAxeXMin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRinsePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResetPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRinseDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.Button buttonMoveOn;
        private System.Windows.Forms.Timer timerProccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSprayGrammage;
        private System.Windows.Forms.NumericUpDown numericUpDownSpraySize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpeedLine;
        private System.Windows.Forms.Label labelSprayUse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCycleDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSprayUseSum;
        private System.Windows.Forms.NumericUpDown numericUpDownAxeXMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownAxeXMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelWidthSizeSpray;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAxeDuration;
        private System.Windows.Forms.Button buttonGlue;
        private System.Windows.Forms.Button buttonRinse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAxeXSpeed;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.NumericUpDown numericUpDownRinsePosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownResetPosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownRinseDuration;
        private System.Windows.Forms.Label labelRinseDuration;
        private System.Windows.Forms.ProgressBar progressBarLineSpeed;
    }
}