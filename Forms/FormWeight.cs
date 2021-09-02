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
                outputPounds = inputKilograms * 2.20;
                labelOutputKGtoPounds.Text = String.Format("{0:0.00}", outputPounds);
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
                outputKilograms = inputPounds * 0.45;
                labelOutputPoundstoKG.Text = String.Format("{0:0.00}", outputKilograms);
            }
        }
    }
}
