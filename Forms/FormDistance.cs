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
    public partial class FormDistance : Form
    {
        public FormDistance()
        {
            InitializeComponent();
        }

        private void buttonSubmitKilometersToMiles_Click(object sender, EventArgs e)
        {
            textBoxKilometersToMiles.ForeColor = Color.Black;
            double outputMiles;

            if (!double.TryParse(textBoxKilometersToMiles.Text, out double inputKilometers))
            {
                textBoxKilometersToMiles.ForeColor = Color.Red;
                textBoxKilometersToMiles.Text = "Enter a valid number";
            }
            else
            {
                outputMiles = inputKilometers * 0.621371;
                labelOutputKilometersToMiles.Text = string.Format("{0:0.00} mi", outputMiles);
            }
        }

        private void buttonSubmitMilesToKilometers_Click(object sender, EventArgs e)
        {
            textBoxMilesToKilometers.ForeColor = Color.Black;
            double outputKilometers;

            if (!double.TryParse(textBoxMilesToKilometers.Text, out double inputMiles))
            {
                textBoxMilesToKilometers.ForeColor = Color.Red;
                textBoxMilesToKilometers.Text = "Enter a valid number";
            }
            else
            {
                outputKilometers = inputMiles * 1.60934;
                labelOutputMilesToKilometers.Text = string.Format("{0:0.00} km", outputKilometers);
            }
        }
    }
}
