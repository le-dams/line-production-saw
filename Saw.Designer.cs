namespace IsoMetall_calcul
{
    partial class Saw
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
            this.timerCutting = new System.Windows.Forms.Timer(this.components);
            this.buttonCut = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedCutting = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeedReverse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLengthPanel = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeedBlank = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedY = new System.Windows.Forms.NumericUpDown();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.checkBoxReady = new System.Windows.Forms.CheckBox();
            this.checkBoxCuttingDouble = new System.Windows.Forms.CheckBox();
            this.checkBoxAxeX = new System.Windows.Forms.CheckBox();
            this.checkBoxAxeY = new System.Windows.Forms.CheckBox();
            this.checkBoxAxeXReset = new System.Windows.Forms.CheckBox();
            this.checkBoxAxeYReset = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelPositionY = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSpeedLine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedCutting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedReverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCutting
            // 
            this.timerCutting.Tick += new System.EventHandler(this.timerCutting_Tick);
            // 
            // buttonCut
            // 
            this.buttonCut.Location = new System.Drawing.Point(161, 307);
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(75, 23);
            this.buttonCut.TabIndex = 3;
            this.buttonCut.Text = "Couper";
            this.buttonCut.UseVisualStyleBackColor = true;
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(261, 307);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(47, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Vitesse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Vitesse Y retour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vitesse X en travail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vitesse X à vide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Largeur panneau";
            // 
            // numericUpDownSpeedCutting
            // 
            this.numericUpDownSpeedCutting.Location = new System.Drawing.Point(151, 67);
            this.numericUpDownSpeedCutting.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedCutting.Name = "numericUpDownSpeedCutting";
            this.numericUpDownSpeedCutting.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeedCutting.TabIndex = 17;
            this.numericUpDownSpeedCutting.ValueChanged += new System.EventHandler(this.numericUpDownSpeedCutting_ValueChanged);
            // 
            // numericUpDownSpeedReverse
            // 
            this.numericUpDownSpeedReverse.Location = new System.Drawing.Point(154, 41);
            this.numericUpDownSpeedReverse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedReverse.Name = "numericUpDownSpeedReverse";
            this.numericUpDownSpeedReverse.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeedReverse.TabIndex = 16;
            this.numericUpDownSpeedReverse.ValueChanged += new System.EventHandler(this.numericUpDownSpeedReverse_ValueChanged);
            // 
            // numericUpDownLengthPanel
            // 
            this.numericUpDownLengthPanel.Enabled = false;
            this.numericUpDownLengthPanel.Location = new System.Drawing.Point(151, 48);
            this.numericUpDownLengthPanel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLengthPanel.Name = "numericUpDownLengthPanel";
            this.numericUpDownLengthPanel.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLengthPanel.TabIndex = 15;
            // 
            // numericUpDownSpeedBlank
            // 
            this.numericUpDownSpeedBlank.Location = new System.Drawing.Point(150, 41);
            this.numericUpDownSpeedBlank.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedBlank.Name = "numericUpDownSpeedBlank";
            this.numericUpDownSpeedBlank.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeedBlank.TabIndex = 14;
            this.numericUpDownSpeedBlank.ValueChanged += new System.EventHandler(this.numericUpDownSpeedBlank_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Vitesse X";
            // 
            // numericUpDownSpeedX
            // 
            this.numericUpDownSpeedX.Enabled = false;
            this.numericUpDownSpeedX.Location = new System.Drawing.Point(151, 15);
            this.numericUpDownSpeedX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedX.Name = "numericUpDownSpeedX";
            this.numericUpDownSpeedX.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeedX.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Vitesse Y";
            // 
            // numericUpDownSpeedY
            // 
            this.numericUpDownSpeedY.Location = new System.Drawing.Point(154, 15);
            this.numericUpDownSpeedY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedY.Name = "numericUpDownSpeedY";
            this.numericUpDownSpeedY.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSpeedY.TabIndex = 26;
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(63, 205);
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(377, 45);
            this.trackBarX.TabIndex = 28;
            this.trackBarX.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(12, 12);
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarY.Size = new System.Drawing.Size(45, 440);
            this.trackBarY.TabIndex = 29;
            // 
            // checkBoxReady
            // 
            this.checkBoxReady.AutoSize = true;
            this.checkBoxReady.Enabled = false;
            this.checkBoxReady.Location = new System.Drawing.Point(21, 102);
            this.checkBoxReady.Name = "checkBoxReady";
            this.checkBoxReady.Size = new System.Drawing.Size(119, 17);
            this.checkBoxReady.TabIndex = 30;
            this.checkBoxReady.Text = "Prête pour la coupe";
            this.checkBoxReady.UseVisualStyleBackColor = true;
            // 
            // checkBoxCuttingDouble
            // 
            this.checkBoxCuttingDouble.AutoSize = true;
            this.checkBoxCuttingDouble.Location = new System.Drawing.Point(150, 74);
            this.checkBoxCuttingDouble.Name = "checkBoxCuttingDouble";
            this.checkBoxCuttingDouble.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCuttingDouble.TabIndex = 31;
            this.checkBoxCuttingDouble.Text = "Double coupe";
            this.checkBoxCuttingDouble.UseVisualStyleBackColor = true;
            this.checkBoxCuttingDouble.CheckedChanged += new System.EventHandler(this.checkBoxCuttingDouble_CheckedChanged);
            // 
            // checkBoxAxeX
            // 
            this.checkBoxAxeX.AutoSize = true;
            this.checkBoxAxeX.Enabled = false;
            this.checkBoxAxeX.Location = new System.Drawing.Point(21, 15);
            this.checkBoxAxeX.Name = "checkBoxAxeX";
            this.checkBoxAxeX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxAxeX.TabIndex = 32;
            this.checkBoxAxeX.Text = "X";
            this.checkBoxAxeX.UseVisualStyleBackColor = true;
            // 
            // checkBoxAxeY
            // 
            this.checkBoxAxeY.AutoSize = true;
            this.checkBoxAxeY.Enabled = false;
            this.checkBoxAxeY.Location = new System.Drawing.Point(21, 58);
            this.checkBoxAxeY.Name = "checkBoxAxeY";
            this.checkBoxAxeY.Size = new System.Drawing.Size(33, 17);
            this.checkBoxAxeY.TabIndex = 33;
            this.checkBoxAxeY.Text = "Y";
            this.checkBoxAxeY.UseVisualStyleBackColor = true;
            // 
            // checkBoxAxeXReset
            // 
            this.checkBoxAxeXReset.AutoSize = true;
            this.checkBoxAxeXReset.Enabled = false;
            this.checkBoxAxeXReset.Location = new System.Drawing.Point(21, 35);
            this.checkBoxAxeXReset.Name = "checkBoxAxeXReset";
            this.checkBoxAxeXReset.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAxeXReset.TabIndex = 34;
            this.checkBoxAxeXReset.Text = "X - Reset";
            this.checkBoxAxeXReset.UseVisualStyleBackColor = true;
            // 
            // checkBoxAxeYReset
            // 
            this.checkBoxAxeYReset.AutoSize = true;
            this.checkBoxAxeYReset.Enabled = false;
            this.checkBoxAxeYReset.Location = new System.Drawing.Point(21, 79);
            this.checkBoxAxeYReset.Name = "checkBoxAxeYReset";
            this.checkBoxAxeYReset.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAxeYReset.TabIndex = 35;
            this.checkBoxAxeYReset.Text = "Y - Reset";
            this.checkBoxAxeYReset.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(473, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 440);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelSpeedLine);
            this.tabPage3.Controls.Add(this.numericUpDownLengthPanel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.checkBoxCuttingDouble);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(338, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Infos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.numericUpDownSpeedBlank);
            this.tabPage1.Controls.Add(this.numericUpDownSpeedCutting);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numericUpDownSpeedX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Axe X";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownSpeedY);
            this.tabPage2.Controls.Add(this.numericUpDownSpeedReverse);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Axe Y";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelPositionY);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.checkBoxAxeX);
            this.tabPage4.Controls.Add(this.checkBoxReady);
            this.tabPage4.Controls.Add(this.checkBoxAxeYReset);
            this.tabPage4.Controls.Add(this.checkBoxAxeY);
            this.tabPage4.Controls.Add(this.checkBoxAxeXReset);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(338, 414);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Capteurs";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelPositionY
            // 
            this.labelPositionY.AutoSize = true;
            this.labelPositionY.Location = new System.Drawing.Point(78, 122);
            this.labelPositionY.Name = "labelPositionY";
            this.labelPositionY.Size = new System.Drawing.Size(10, 13);
            this.labelPositionY.TabIndex = 39;
            this.labelPositionY.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Position Y:";
            // 
            // labelSpeedLine
            // 
            this.labelSpeedLine.AutoSize = true;
            this.labelSpeedLine.Location = new System.Drawing.Point(148, 24);
            this.labelSpeedLine.Name = "labelSpeedLine";
            this.labelSpeedLine.Size = new System.Drawing.Size(10, 13);
            this.labelSpeedLine.TabIndex = 32;
            this.labelSpeedLine.Text = "-";
            // 
            // Saw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCut);
            this.Location = new System.Drawing.Point(200, 40);
            this.Name = "Saw";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedCutting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedReverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerCutting;
        private System.Windows.Forms.Button buttonCut;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedCutting;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedReverse;
        private System.Windows.Forms.NumericUpDown numericUpDownLengthPanel;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedBlank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.CheckBox checkBoxReady;
        private System.Windows.Forms.CheckBox checkBoxCuttingDouble;
        private System.Windows.Forms.CheckBox checkBoxAxeX;
        private System.Windows.Forms.CheckBox checkBoxAxeY;
        private System.Windows.Forms.CheckBox checkBoxAxeXReset;
        private System.Windows.Forms.CheckBox checkBoxAxeYReset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labelPositionY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSpeedLine;
    }
}