using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoMetall_calcul
{
    public partial class Saw : Form
    {
        // Main
        private Main mainFrame = null;

        const int MAX_X = 1300;
        const int MAX_Y = 4000;
        const int INTERVAL = 100;
        const int LENGTH_LINE = 5000;

        // Variables changed

        // POWER
        private bool axeX = false;
        private bool axeXReset = false;
        private bool axeXDouble = true;
        private int axeXDoubleDirection = 1;

        private bool axeY = false;
        private bool axeYReset = false;

        // SPEEDS
        private int axe_x_speed = 0; // mm/s
        private int axe_x_speedCuttingEmpty = 450; // mm/s
        private int axe_x_speedCutting = 300; // mm/s

        private int axe_y_speed = 0; // mm/s
        private int axe_y_speedReverse = 200; // mm/s

        // Variables static
        private int positionStartLimit = 200;

        public Saw()
        {
            InitializeComponent();
            this.init();
        }

        public void setMainFrame(Main _main)
        {
            this.mainFrame = _main;
        }

        private void init()
        {
            this.trackBarX.Maximum = MAX_X;
            this.trackBarY.Maximum = MAX_Y;

            this.numericUpDownSpeedBlank.Value = this.axe_x_speedCuttingEmpty;
            this.numericUpDownSpeedCutting.Value = this.axe_x_speedCutting;
            this.numericUpDownSpeedReverse.Value = this.axe_y_speedReverse;

            this.numericUpDownSpeedX.Value = this.axe_x_speed;
            this.numericUpDownSpeedY.Value = this.axe_y_speed;

            this.checkBoxCuttingDouble.Checked = this.axeXDouble;

            this.timerCutting.Interval = INTERVAL;
            this.timerCutting.Start();
        }

        private void AxeX() // CUTTING
        {
            int position = this.trackBarX.Value;

            if (this.axeX == true)
            {
                // Reset
                if (this.axeXReset == true)
                {
                    if (this.axeXDouble == true)
                    {
                        // Close cycle
                        this.axeX = false;
                        this.axeYReset = true;
                        this.axeXReset = false;
                    }
                    else
                    {
                        this.setAxeXSpeed(this.axe_x_speedCuttingEmpty);
                        position += -(this.axe_x_speed);
                        
                        // Close cycle
                        if(position <= 0)
                        {
                            position = 0;
                            this.axeX = false;
                            this.axeXReset = false;
                            this.axeYReset = true;
                        }

                        this.trackBarX.Value = position;
                    }
                }

                // Cutting proccess
                else
                {
                    // Blank
                    if (position < this.getWidthBlankStart() || position > (this.getWidthBlankStart() + this.getWidthSheet()))
                    {
                        this.setAxeXSpeed(this.axe_x_speedCuttingEmpty);
                    }
                    // Panel
                    else
                    {
                        this.setAxeXSpeed(this.axe_x_speedCutting);
                    }

                    // Reverse Direction
                    if (this.axeXDouble == true && this.axeXDoubleDirection == -1)
                    {
                        position += -(this.axe_x_speed / 10);

                        if (position <= 0)
                        {
                            position = 0;

                            // Stop
                            this.axeX = false;
                            this.axeXReset = false;
                            this.axeYReset = true;
                            this.axeXDoubleDirection = 1;
                        }

                        this.trackBarX.Value = position;
                    }

                    // Normal Direction 
                    else
                    {
                        position += (this.axe_x_speed / 10);

                        if (position >= this.trackBarX.Maximum)
                        {
                            position = this.trackBarX.Maximum;

                            // Stop
                            this.axeXReset = true;
                            if(this.axeXDouble == true)
                            {
                                this.axeXDoubleDirection = -1;
                            }
                        }

                        this.trackBarX.Value = position;
                    }
                }
            }
        }

        private void AxeY() // FOLLOWING
        {
            int position = this.trackBarY.Value;
            if(this.axeX == true)
            {
                position += this.getSpeedLine();

                if (position >= MAX_Y)
                {
                    position = MAX_Y;
                }

                this.trackBarY.Value = position;
                this.axeY = true;
            }
            else if(this.axeX == false && this.axeYReset == true)
            {
                position += -(this.axe_y_speedReverse);

                if(position <= 0)
                {
                    position = 0;
                    this.axeYReset = false;
                }

                this.trackBarY.Value = position;
                this.axeY = true;
            }
            else
            {
                this.axeY = false;
            }
        }

        private void getInfo()
        {
            this.checkBoxReady.Checked = (this.axeX == false && this.axeY == false && this.axeYReset == false && this.axeXReset == false);
            this.checkBoxAxeX.Checked = this.axeX;
            this.checkBoxAxeY.Checked = this.axeY;
            this.checkBoxAxeXReset.Checked = this.axeXReset;
            this.checkBoxAxeYReset.Checked = this.axeYReset;

            this.labelPositionY.Text = this.trackBarY.Value.ToString();
            this.labelSpeedLine.Text = this.mainFrame.getSpeedLineMeter() + " m/s.";

            this.numericUpDownLengthPanel.Value = this.getWidthSheet();
        }

        // GETTER
        private int getSpeedLine()
        {
            return Convert.ToInt32(this.mainFrame.getSpeedLine());
        }

        private int getWidthSheet()
        {
            return this.mainFrame.getSheetWidth();
        }

        private int getWidthBlankStart()
        {
            return MAX_X - this.getWidthSheet() - this.positionStartLimit;
        }

        private int getWidthBlankEnd()
        {
            return this.positionStartLimit;
        }

        private void setAxeXSpeed(int _speed)
        {
            this.axe_x_speed = _speed;
            this.numericUpDownSpeedX.Value = this.axe_x_speed;
        }

        private void setAxeYSpeed(int _speed)
        {
            this.axe_y_speed = _speed;
            this.numericUpDownSpeedY.Value = this.axe_y_speed;
        }

        private void sync() { }

        private void _cutting()
        {
            this.axeX = true;
            this.axeXReset = false;
            this.axeYReset = false;
        }

        /*
         * ACTIONS BUTTONS
         */

        private void timerCutting_Tick(object sender, EventArgs e)
        {
            this.AxeX();
            this.AxeY();

            this.getInfo();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            this._cutting();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.axeX = false;
            this.axeY = false;

            this.trackBarX.Value = 0;
            this.trackBarY.Value = 0;
        }

        private void numericUpDownSpeedBlank_ValueChanged(object sender, EventArgs e)
        {
            // Vitesse coupe à vide
            this.axe_x_speedCuttingEmpty = Convert.ToInt32(numericUpDownSpeedBlank.Value);
            this.sync();
        }

        private void numericUpDownSpeedCutting_ValueChanged(object sender, EventArgs e)
        {
            // Vitesse coupe
            this.axe_x_speedCutting = Convert.ToInt32(numericUpDownSpeedCutting.Value);
            this.sync();
        }

        private void numericUpDownSpeedReverse_ValueChanged(object sender, EventArgs e)
        {
            // Vitesse retour
            this.axe_y_speedReverse = Convert.ToInt32(numericUpDownSpeedReverse.Value);
            this.sync();
        }

        private void checkBoxCuttingDouble_CheckedChanged(object sender, EventArgs e)
        {
            this.axeXDouble = checkBoxCuttingDouble.Checked;
        }
    }
}
