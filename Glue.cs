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
    public partial class Glue : Form
    {
        // CONSTANTES
        const int INTERVAL = 100;
        const int MAX_AXE_X_WIDTH = 1400;
        const int MAX_SPRAY_WEIGTHS = 1000;
        const int MAX_SPRAY_WEIGTHS_LIMIT = 30; // gr/s
        const int MAX_SPRAY_SIZE = 200;

        // Main
        private Main mainFrame = null;

        // Glue
        private int spray_size = 70; // mm
        private int spray_weights = 190; // gr/m2
        private double spray_use = 0.0;
        private int spray_duration = 0;  
        
        // State
            // Axe
            private bool axeXPower = false;
            private bool axeXReset = false;
            private int axeXPosition = 0;
            private int axeXDirection = 0;
            private int axeXPostionReset = 0;
            private int axeXMin = 135; // FRONT 
            private int axeXMax = 1265; // REAR

            // GLue
            private bool projectionPower = false;
            private bool rinsePower = false;
            private int rinseSpeed = 80;
            private int rinseDuration = 50; // s/10
            private int rinseDurationI = 0;
            private int rinsePosition = MAX_AXE_X_WIDTH;

        public Glue()
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
            this.numericUpDownSprayGrammage.Maximum = MAX_SPRAY_WEIGTHS;
            this.numericUpDownSpraySize.Maximum = MAX_SPRAY_SIZE;
            this.numericUpDownAxeXMin.Maximum = MAX_AXE_X_WIDTH;
            this.numericUpDownAxeXMax.Maximum = MAX_AXE_X_WIDTH;
            this.numericUpDownRinsePosition.Maximum = MAX_AXE_X_WIDTH;
            this.numericUpDownResetPosition.Maximum = MAX_AXE_X_WIDTH;
            this.numericUpDownRinseDuration.Maximum = 200;

            this.numericUpDownAxeXMax.Value = this.axeXMax;
            this.numericUpDownAxeXMin.Value = this.axeXMin;
            this.numericUpDownResetPosition.Value = this.axeXPostionReset;
            this.numericUpDownRinsePosition.Value = this.rinsePosition;
            this.numericUpDownRinseDuration.Value = this.rinseDuration;

            this.setSpraySize(this.spray_size);
            this.setSprayWeights(this.spray_weights);

            this.trackBarPosition.Maximum = MAX_AXE_X_WIDTH;
            this.trackBarPosition.Value = axeXPosition;

            this.timerProccess.Interval = INTERVAL;
            this.timerProccess.Start();

            this.progressBarLineSpeed.Maximum = 100;
        }

        // GETTER INFO

        private double getGrammageBySec()
        {
            return (double)this.spray_weights / 10000 * this.getSquareBySec();
        }

        private double getSquareBySec() // mm2/sec
        {
            return this.getSheetWidth() / this.getSecByCycle();
        }

        private double getSecByCycle()
        {
            return getSecByMeter() / (100 / this.spray_size);
        }

        private double getSecByMeter()
        {
           return  (60 / (double)this.mainFrame.getSpeedLine() * 1000 / 600);
        }

        private int getSheetWidth()
        {
            return this.axeXMax - this.axeXMin;
        }

        private int getAxeXSpeed()
        {
            return (this.rinsePower || this.axeXReset) ? this.rinseSpeed : Convert.ToInt32(this.getSquareBySec() / 10);
        }

        private void getInfo()
        {
            this.labelSpeedLine.Text = this.mainFrame.getSpeedLineMeter() + " m/s.";
            this.labelSprayUse.Text = this.getGrammageBySec() + " gr/sec.";
            this.labelSprayUse.ForeColor = this.getGrammageBySec() > MAX_SPRAY_WEIGTHS_LIMIT ? Color.Red : Color.Black;
            this.labelSprayUseSum.Text = Math.Round(this.spray_use,2) + " gr";
            this.labelCycleDuration.Text = Math.Round(this.getSecByCycle(),2) + " sec.";
            this.labelWidthSizeSpray.Text = this.getSheetWidth() + " mm";
            this.labelAxeXSpeed.Text = (this.getAxeXSpeed()*(1000/INTERVAL)).ToString() + " mm/sec.";
            this.labelRinseDuration.Text = "Durée de rinçage ("+this.rinseDurationI.ToString()+")";

            if(this.spray_duration/10 > 60)
            {
                this.toolStripStatusLabelAxeDuration.Text = ((double)this.spray_duration / 600).ToString("#.#") + " minutes";
            }
            else
            {
                this.toolStripStatusLabelAxeDuration.Text = ((double)this.spray_duration / 10).ToString("#") + " sec.";
            }
            this.buttonMoveOn.BackColor = this.axeXPower ? Color.Green : Color.Red;
            this.buttonGlue.BackColor = this.projectionPower ? Color.Green : Color.Red;
            this.buttonRinse.BackColor = this.rinsePower ? Color.Orange : default(Color);
            this.buttonReset.BackColor = this.axeXReset ? Color.LightBlue : default(Color);

            this.progressBarLineSpeed.Value = (int)((double)mainFrame.getSpeedLine() / (double)mainFrame.getSpeedLineMax() * (double)100);
        }

        // SETTER
        private void setXPosition(int position)
        {
            // Correct
            if(position >= MAX_AXE_X_WIDTH)
            {
                position = MAX_AXE_X_WIDTH;
            }
            else if(position < 0)
            {
                position = 0;
            }

            this.axeXPosition = position;
            this.trackBarPosition.Value = position;
        }

        private void setSprayWeights(int weights,bool auto = true)
        {
            this.spray_weights = weights;
            if(auto)
                this.numericUpDownSprayGrammage.Value = weights;
        }
        private void setSpraySize(int size, bool auto = true)
        {
            this.spray_size = size;
            if(auto)
                this.numericUpDownSpraySize.Value = size;
        }

        private void setAxeMin(int value)
        {
            this.axeXMin = value;
            this.numericUpDownAxeXMin.Value = this.axeXMin;
        }

        private void setAxeMax(int value)
        {
            this.axeXMax = value;
            this.numericUpDownAxeXMax.Value = this.axeXMax;
        }

        public void setSheetWidth(int value)
        {
            if (this.axeXMax - this.mainFrame.getSheetWidth() >= 0)
            {
                this.setAxeMin(this.axeXMax - this.mainFrame.getSheetWidth());
            }
            else
            {
                int _value = (MAX_AXE_X_WIDTH - this.mainFrame.getSheetWidth()) / 2;
                this.setAxeMax(_value);
                this.setAxeMin(_value);
            }
        }

        // PROCCESS
        private void move()
        {
            int position = this.axeXPosition;

            if (this.axeXPower == true)
            {
                // Position
                position += this.getAxeXSpeed() * this.axeXDirection;

                if (this.rinsePower)
                {
                    if (position >= this.rinsePosition && this.axeXDirection==1 || position >= this.rinsePosition && this.axeXDirection == -1)
                        position = this.rinsePosition;

                    if (this.rinsePosition != this.axeXPosition)
                    {
                        this.setXPosition(position);
                    }
                    else
                    {
                        ++this.rinseDurationI;

                        if (this.rinseDurationI >= this.rinseDuration)
                        {
                            this.reset();
                        }
                    }
                }
                else if (this.axeXReset)
                {
                    if (position >= this.axeXPostionReset && this.axeXDirection == 1 || position >= this.axeXPostionReset && this.axeXDirection == -1)
                        position = this.axeXPostionReset;

                    if (this.axeXPostionReset != this.axeXPosition)
                    {
                        this.setXPosition(position);
                    }
                    else
                    {
                        this.axeXPower = false;
                        this.axeXReset = false;
                    }
                }
                else
                {
                    if (position >= this.axeXMax)
                    {
                        position = this.axeXMax;
                        this.axeXDirection = -1;
                    }
                    else if (position <= this.axeXMin)
                    {
                        position = this.axeXMin;
                        this.axeXDirection = 1;
                    }
                    this.setXPosition(position);
                }

            }
        }

        private void reset()
        {
            this.axeXReset = true;

            this.rinsePower = false;
            this.rinseDurationI = 0;
            this.projectionPower = false;
            this.axeXPower = true;
            this.axeXDirection = this.axeXPosition < this.axeXPostionReset ? 1 : -1;
        }

        private void rinse()
        {
            this.rinsePower = !this.rinsePower;

            if (this.rinsePower)
            {
                this.projectionPower = false;
                this.axeXPower = true;
                this.axeXDirection = this.axeXPosition < this.rinsePosition ? 1 : -1;
            }
        }

        private void projection()
        {
            if(this.projectionPower)
            {
                // Spray
                ++this.spray_duration;
                this.spray_use += this.getGrammageBySec() / (1000 / INTERVAL);
            }
        }

        // ACTION

        private void buttonMoveOn_Click(object sender, EventArgs e)
        {
            this.axeXPower = !this.axeXPower;
        }

        private void timerProccess_Tick(object sender, EventArgs e)
        {
            this.move();
            this.projection();

            this.getInfo();
        }

        private void numericUpDownSprayGrammage_ValueChanged(object sender, EventArgs e)
        {
            this.setSprayWeights(Convert.ToInt32(this.numericUpDownSprayGrammage.Value),false);
        }

        private void numericUpDownSpraySize_ValueChanged(object sender, EventArgs e)
        {
            this.setSpraySize(Convert.ToInt32(this.numericUpDownSpraySize.Value),false);
        }

        private void numericUpDownAxeXMax_ValueChanged(object sender, EventArgs e)
        {
            this.setAxeMax(Convert.ToInt32(this.numericUpDownAxeXMax.Value));
        }

        private void numericUpDownAxeXMin_ValueChanged(object sender, EventArgs e)
        {
            this.setAxeMin(Convert.ToInt32(this.numericUpDownAxeXMin.Value));
        }

        private void Glue_Load(object sender, EventArgs e)
        {

        }

        private void buttonGlue_Click(object sender, EventArgs e)
        {
            this.projectionPower = !this.projectionPower;
        }

        private void buttonRinse_Click(object sender, EventArgs e)
        {
            this.rinse();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void numericUpDownResetPosition_ValueChanged(object sender, EventArgs e)
        {
            this.axeXPostionReset = Convert.ToInt32(this.numericUpDownResetPosition.Value);
        }

        private void numericUpDownRinsePosition_ValueChanged(object sender, EventArgs e)
        {
            this.rinsePosition = Convert.ToInt32(this.numericUpDownRinsePosition.Value);
        }

        private void numericUpDownRinseDuration_ValueChanged(object sender, EventArgs e)
        {
            this.rinseDuration = Convert.ToInt32(this.numericUpDownRinseDuration.Value);
        }
    }
}
