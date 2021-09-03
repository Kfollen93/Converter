using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter.Forms
{
    public partial class FormSpeed : Form
    {
        public FormSpeed()
        {
            InitializeComponent();
        }

        private void buttonSubmitKMHtoMPH_Click(object sender, EventArgs e)
        {
            textBoxKMHtoMPH.ForeColor = Color.Black;
            double outputMPH;

            if (!double.TryParse(textBoxKMHtoMPH.Text, out double inputKMH))
            {
                textBoxKMHtoMPH.ForeColor = Color.Red;
                textBoxKMHtoMPH.Text = "Enter a valid number";
            }
            else
            {
                outputMPH = inputKMH * 0.621371;
                labelOutputKMHtoMPH.Text = string.Format("{0:0.00} MPH", outputMPH);
            }
        }

        private void buttonSubmitMPHtoKMH_Click(object sender, EventArgs e)
        {
            textBoxMPHtoKMH.ForeColor = Color.Black;
            double outputKMH;

            if (!double.TryParse(textBoxMPHtoKMH.Text, out double inputMPH))
            {
                textBoxMPHtoKMH.ForeColor = Color.Red;
                textBoxMPHtoKMH.Text = "Enter a valid number";
            }
            else
            {
                outputKMH = inputMPH * 1.60934;
                labelOutputMPHtoKMH.Text = string.Format("{0:0.00} KMH", outputKMH);
            }
        }
    }
}
