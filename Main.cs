using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsoMetall_calcul
{
    public partial class Main : Form
    {
        const bool GLUE = true;
        const bool SAW = true;

        // COMPONNENTS
        Glue Glue = null;
        Saw Saw = null;

        const int WIDTH_MAX = 1400;
        const double SPEED_MIN = 0.7;
        const double SPEED_MAX = 10.0;
        const int INTERVAL = 100;

        //"C:\\Users\\le-dams\\Desktop\\K8055D.DLL"
        private Device device = new Device(0);

        private double speed_line = 1.5;
        private int sheet_width = 1000;

        private int production_length = 0;
        private int production_duration = 0;

        private bool powerProduction = false;

        public Main()
        {
            InitializeComponent();

            this.init();
        }

        // INIT

        private void init()
        {
            this.timerGlobal.Interval = INTERVAL;
            this.timerGlobal.Start();

            this.numericUpDownSpeedLine.Minimum = Convert.ToDecimal(SPEED_MIN);
            this.numericUpDownSpeedLine.Maximum = Convert.ToDecimal(SPEED_MAX);
            this.numericUpDownSheetWidth.Maximum = WIDTH_MAX;

            // GLUE
            if (GLUE)
            {
                this.Glue = new Glue();
                this.Glue.setMainFrame(this);
                this.Glue.Visible = true;
            }

            // Saw
            if (SAW)
            {
                this.Saw = new Saw();
                this.Saw.setMainFrame(this);
                this.Saw.Visible = true;
            }

            this.setSheetWidth(sheet_width);
        }
        
        // PRODUCTION
        
        private void production()
        {
            if (this.powerProduction)
            {
                this.production_length += this.getSpeedLine();
                this.production_duration++;
            }
        } 

        private void getInfo()
        {
            CultureInfo ci = new CultureInfo("fr-be");
            this.toolStripStatusLabelLengthSum.Text = "Longueure déroulée: " + (Convert.ToDecimal(this.production_length) / 1000).ToString("F", ci) + " m";
            


            this.buttonPowerOn.Enabled = !this.powerProduction;
            this.buttonPowerOff.Enabled = this.powerProduction;
           
        }

        private void powerOn()
        {
            this.powerProduction = true;

            device.on();
        }

        private void powerOff()
        {
            this.powerProduction = false;

            device.off();
        }

        public void haltLine()
        {

        }

        // SETTER


        public void setSpeedLine(double speed)
        {
            this.speed_line = speed;
            this.numericUpDownSpeedLine.Value = Convert.ToDecimal(this.speed_line);
        }

        public void setSheetWidth(int width)
        {
            this.sheet_width = width;
            this.numericUpDownSheetWidth.Value = Convert.ToInt32(this.sheet_width);

            // Change
            if (GLUE)
            {
                this.Glue.setSheetWidth(this.sheet_width);
            }
        }

        // GETTER

        public double getSpeedLineMeter()
        {
            return this.speed_line;
        }

        public int getSpeedLine() // mm/s
        {
            return Convert.ToInt32(this.speed_line * 1000 / 60);
        }

        public int getSpeedLineMax()
        {
            return Convert.ToInt32(SPEED_MAX * 1000 / 60);
        }

        public double getSpeedLineMeterMax()
        {
            return SPEED_MAX;
        }


        public int getSheetWidth()
        {
            return this.sheet_width;
        }


        // ACTION

        private void numericUpDownSpeedLine_ValueChanged(object sender, EventArgs e)
        {
            this.setSpeedLine(Convert.ToDouble(this.numericUpDownSpeedLine.Value));
        }

        private void numericUpDownSheetWidth_ValueChanged(object sender, EventArgs e)
        {
            this.setSheetWidth(Convert.ToInt32(this.numericUpDownSheetWidth.Value));
        }

        private void timerGlobal_Tick(object sender, EventArgs e)
        {
            this.production();
            this.getInfo();
        }

        private void buttonPowerOn_Click(object sender, EventArgs e)
        {
            this.powerOn();
        }

        private void buttonPowerOff_Click(object sender, EventArgs e)
        {
            this.powerOff();
        }
    }
}
