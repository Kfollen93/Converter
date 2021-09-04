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
    public partial class FormLength : Form
    {
        public FormLength()
        {
            InitializeComponent();
        }

        private void buttonSubmitCMtoInches_Click(object sender, EventArgs e)
        {
            textBoxCMtoInches.ForeColor = Color.Black;
            double outputInches;

            if (!double.TryParse(textBoxCMtoInches.Text, out double inputCentimeters))
            {
                textBoxCMtoInches.ForeColor = Color.Red;
                textBoxCMtoInches.Text = "Enter a valid number";
            }
            else
            {
                outputInches = inputCentimeters * 0.393701;
                labelOutputCMtoInches.Text = string.Format("{0:0.00} in", outputInches);
            }
        }

        private void buttonSubmitInchesToCM_Click(object sender, EventArgs e)
        {
            textBoxInchesToCM.ForeColor = Color.Black;
            double outputCentimeters;

            if (!double.TryParse(textBoxInchesToCM.Text, out double inputInches))
            {
                textBoxInchesToCM.ForeColor = Color.Red;
                textBoxInchesToCM.Text = "Enter a valid number";
            }
            else
            {
                outputCentimeters = inputInches * 2.54;
                labelOutputInchesToCM.Text = string.Format("{0:0.00} cm", outputCentimeters);
            }
        }

        private void buttonSubmitMetersToFeet_Click(object sender, EventArgs e)
        {
            textBoxMetersToFeet.ForeColor = Color.Black;
            double outputFeet;

            if (!double.TryParse(textBoxMetersToFeet.Text, out double inputMeters))
            {
                textBoxMetersToFeet.ForeColor = Color.Red;
                textBoxMetersToFeet.Text = "Enter a valid number";
            }
            else
            {
                outputFeet = inputMeters * 3.28084;
                if (outputFeet <= 1)
                {
                    labelOutputMetersToFeet.Text = string.Format("{0:0.00} foot", outputFeet);
                }
                else
                {
                    labelOutputMetersToFeet.Text = string.Format("{0:0.00} feet", outputFeet);
                }
            }
        }

        private void buttonSubmitFeetToMeters_Click(object sender, EventArgs e)
        {
            textBoxFeetToMeters.ForeColor = Color.Black;
            double outputMeters;

            if (!double.TryParse(textBoxFeetToMeters.Text, out double inputFeet))
            {
                textBoxFeetToMeters.ForeColor = Color.Red;
                textBoxFeetToMeters.Text = "Enter a valid number";
            }
            else
            {
                outputMeters = inputFeet * 0.3048;
                if (outputMeters <= 1)
                {
                    labelOutputFeetToMeters.Text = string.Format("{0:0.00} meter", outputMeters);
                }
                else
                {
                    labelOutputFeetToMeters.Text = string.Format("{0:0.00} meters", outputMeters);
                }
            }
        }
    }
}
