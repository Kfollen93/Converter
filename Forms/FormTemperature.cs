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
    public partial class FormTemperature : Form
    {
        public FormTemperature()
        {
            InitializeComponent();
        }

        private void buttonSubmitCtoF_Click(object sender, EventArgs e)
        {
            textBoxCtoF.ForeColor = Color.Black;
            double outputFahrenheit;

            if (!double.TryParse(textBoxCtoF.Text, out double inputCelcius))
            {
                textBoxCtoF.ForeColor = Color.Red;
                textBoxCtoF.Text = "Enter a valid number";
            }
            else
            {
                outputFahrenheit = (inputCelcius * 9 / 5) + 32;
                labelOutputCtoF.Text = string.Format("{0:0.00}" + "°F", outputFahrenheit);
            }
        }

        private void buttonSubmitFtoC_Click(object sender, EventArgs e)
        {
            textBoxFtoC.ForeColor = Color.Black;
            double outputCelcius;

            if (!double.TryParse(textBoxFtoC.Text, out double inputFahrenheit))
            {
                textBoxFtoC.ForeColor = Color.Red;
                textBoxFtoC.Text = "Enter a valid number";
            }
            else
            {
                outputCelcius = (inputFahrenheit - 32) *5 / 9;
                labelOutputFtoC.Text = string.Format("{0:0.00}" + "°C", outputCelcius);
            }
        }
    }
}
