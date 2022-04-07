using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricConverter {
    public partial class MetricConversionForm : Form {
        public MetricConversionForm() {
            InitializeComponent();
        }

        private void convertMetersBtn_Click(object sender, EventArgs e) {
            //string meterString = this.getMetersTxt.Text;
            double meters = Math.Round(Convert.ToDouble(this.getMetersTxt.Text), 3);

            double inches = meters * 39.37; ;
            double feetDouble = inches % 12;
            double feet = Math.Floor(feetDouble);
            inches = Math.Round((inches - feet * 12), 1);


            this.setFeetTxt.Text = feet.ToString();
            this.setInchesTxt.Text = inches.ToString();
            //this.setFeetTxt.Text = meters;
            //Console.WriteLine(meters);
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void convertFIBtn_Click(object sender, EventArgs e) {
            //string feetString = this.getMetersLabel.Text;
            int feet = Convert.ToInt32(this.getFeetTxt.Text);
            double inches = Convert.ToDouble(this.getInchesTxt.Text);

            inches += feet * 12;

            double meter = Math.Round(inches / 39.37, 3);
            this.setMetersTxt.Text = meter.ToString();
        }
        

        private void clearMetricBtn_Click(object sender, EventArgs e) {
            this.getMetersTxt.Clear();
            this.setFeetTxt.Clear();
            this.setInchesTxt.Clear();
        }

        private void clearBtn2_Click(object sender, EventArgs e) {
            this.getFeetTxt.Clear();
            this.getInchesTxt.Clear();
            this.setMetersTxt.Clear();
        }
    }
}
