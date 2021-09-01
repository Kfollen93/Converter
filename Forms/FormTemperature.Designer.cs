
namespace Converter.Forms
{
    partial class FormTemperature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTemperature
            // 
            this.labelTemperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(310, 67);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(118, 15);
            this.labelTemperature.TabIndex = 0;
            this.labelTemperature.Text = "Celcius to Fahrenheit";
            // 
            // FormTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTemperature);
            this.Name = "FormTemperature";
            this.Text = "FormTemperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemperature;
    }
}