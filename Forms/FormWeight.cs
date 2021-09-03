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
    public partial class FormWeight : Form
    {
        public FormWeight()
        {
            InitializeComponent();
        }

        private void buttonSubmitKGtoPounds_Click(object sender, EventArgs e)
        {
            textBoxKGtoPounds.ForeColor = Color.Black;
            double outputPounds;
            
            if (!double.TryParse(textBoxKGtoPounds.Text, out double inputKilograms))
            {
                textBoxKGtoPounds.ForeColor = Color.Red;
                textBoxKGtoPounds.Text = "Enter a valid number";
            }
            else
            {
                outputPounds = inputKilograms * 2.20462;
                labelOutputKGtoPounds.Text = string.Format("{0:0.00} lb(s)", outputPounds);
            }
        }

        private void buttonSubmitPoundstoKG_Click(object sender, EventArgs e)
        {
            textBoxPoundstoKG.ForeColor = Color.Black;
            double outputKilograms;

            if (!double.TryParse(textBoxPoundstoKG.Text, out double inputPounds))
            {
                textBoxPoundstoKG.ForeColor = Color.Red;
                textBoxPoundstoKG.Text = "Enter a valid number";
            }
            else
            {
                outputKilograms = inputPounds * 0.453592;
                labelOutputPoundstoKG.Text = string.Format("{0:0.00} kg", outputKilograms);
            }
        }

        private void buttonSubmitGramsToOunces_Click(object sender, EventArgs e)
        {
            textBoxGramsToOunces.ForeColor = Color.Black;
            double outputOunces;

            if (!double.TryParse(textBoxGramsToOunces.Text, out double inputGrams))
            {
                textBoxGramsToOunces.ForeColor = Color.Red;
                textBoxGramsToOunces.Text = "Enter a valid number";
            }
            else
            {
                outputOunces = inputGrams * 0.035274;
                labelOutputGramsToOunces.Text = string.Format("{0:0.00} oz", outputOunces);
            }
        }

        private void buttonSubmitOuncesToGrams_Click(object sender, EventArgs e)
        {
            textBoxOuncesToGrams.ForeColor = Color.Black;
            double outputGrams;

            if (!double.TryParse(textBoxOuncesToGrams.Text, out double inputOunces))
            {
                textBoxOuncesToGrams.ForeColor = Color.Red;
                textBoxOuncesToGrams.Text = "Enter a valid number";
            }
            else
            {
                outputGrams = inputOunces * 28.3495;
                labelOutputOuncesToGrams.Text = string.Format("{0:0.00} g", outputGrams);
            }
        }
    }
}
