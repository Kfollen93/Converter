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
    public partial class FormVolume : Form
    {
        public FormVolume()
        {
            InitializeComponent();
        }

        private void buttonSubmitFluidOzToML_Click(object sender, EventArgs e)
        {
            textBoxFluidOzToML.ForeColor = Color.Black;
            double outputMililiters;

            if (!double.TryParse(textBoxFluidOzToML.Text, out double inputFluidOunces))
            {
                textBoxFluidOzToML.ForeColor = Color.Red;
                textBoxFluidOzToML.Text = "Enter a valid number";
            }
            else
            {
                outputMililiters = inputFluidOunces * 29.5735;
                labelOutputFluidOzToML.Text = string.Format("{0:0.00} mL", outputMililiters);
            }
        }

        private void buttonSubmitMililitersToFluidOz_Click(object sender, EventArgs e)
        {
            textBoxMililitersToFluidOz.ForeColor = Color.Black;
            double outputFluidOunces;

            if (!double.TryParse(textBoxMililitersToFluidOz.Text, out double inputMililiters))
            {
                textBoxMililitersToFluidOz.ForeColor = Color.Red;
                textBoxMililitersToFluidOz.Text = "Enter a valid number";
            }
            else
            {
                outputFluidOunces = inputMililiters * 0.033814;
                labelOutputMililitersToFluidOz.Text = string.Format("{0:0.00} fl oz", outputFluidOunces);
            }
        }

        private void buttonSubmitLitersToGallons_Click(object sender, EventArgs e)
        {
            textBoxLitersToGallons.ForeColor = Color.Black;
            double outputGallons;

            if (!double.TryParse(textBoxLitersToGallons.Text, out double inputLiters))
            {
                textBoxLitersToGallons.ForeColor = Color.Red;
                textBoxLitersToGallons.Text = "Enter a valid number";
            }
            else
            {
                outputGallons = inputLiters * 0.264172;
                labelOutputLitersToGallons.Text = string.Format("{0:0.00} gallon(s)", outputGallons);
            }
        }

        private void buttonSubmitGallonsToLiters_Click(object sender, EventArgs e)
        {
            textBoxGallonsToLiters.ForeColor = Color.Black;
            double outputLiters;

            if (!double.TryParse(textBoxGallonsToLiters.Text, out double inputGallons))
            {
                textBoxGallonsToLiters.ForeColor = Color.Red;
                textBoxGallonsToLiters.Text = "Enter a valid number";
            }
            else
            {
                outputLiters = inputGallons * 3.78541;
                labelOutputGallonsToLiters.Text = string.Format("{0:0.00} liter(s)", outputLiters);
            }
        }
    }
}
