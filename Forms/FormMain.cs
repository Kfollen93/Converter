using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Converter
{
    public partial class FormMain : Form
    {
        private Panel leftBorderButton;
        private IconButton currentButton;
        private Form currentChildForm;
        
        public FormMain()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 50);
            panelMenu.Controls.Add(leftBorderButton);

            // Form
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            /* Instead of doing DoubleBuffered = true to stop form flickering, I am using
               this fix from StackOverFlow which eliminates the flickering when switching forms */
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, tableLayoutPanel1, new object[] { true });
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButtonColorChange(object senderButton, Color color)
        {
            if (senderButton != null)
            {
                DisableButtonColorChange();

                currentButton = (IconButton)senderButton;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();

                // Current Form Icon
                currentChildFormIcon.IconChar = currentButton.IconChar;
                currentChildFormIcon.IconColor = color;
            }
        }

        private void DisableButtonColorChange()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(66, 108, 245);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Only open one form at a time
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHomeChildForm.Text = childForm.Text.Remove(0, 4); // Remove the first 4 chars that include "Form".
        }

        private void weightButton_Click(object sender, EventArgs e)
        {
            ActivateButtonColorChange(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormWeight());
        }

        private void temperatureButton_Click(object sender, EventArgs e)
        {
            ActivateButtonColorChange(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormTemperature());
        }

        private void speedButton_Click(object sender, EventArgs e)
        {
            ActivateButtonColorChange(sender, RGBColors.color3);
        }

        private void distanceButton_Click(object sender, EventArgs e)
        {
            ActivateButtonColorChange(sender, RGBColors.color4);
        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            ActivateButtonColorChange(sender, RGBColors.color5);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            ResetToMain();
        }

        private void ResetToMain()
        {
            DisableButtonColorChange();
            leftBorderButton.Visible = false;
            currentChildFormIcon.IconChar = IconChar.Home;
            currentChildFormIcon.IconColor = Color.Black;
            labelHomeChildForm.Text = "Home";
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
