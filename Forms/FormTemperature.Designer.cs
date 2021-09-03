
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
            this.labelOutputFtoC = new System.Windows.Forms.Label();
            this.buttonSubmitFtoC = new System.Windows.Forms.Button();
            this.textBoxFtoC = new System.Windows.Forms.TextBox();
            this.labelFtoC = new System.Windows.Forms.Label();
            this.labelOutputCtoF = new System.Windows.Forms.Label();
            this.buttonSubmitCtoF = new System.Windows.Forms.Button();
            this.textBoxCtoF = new System.Windows.Forms.TextBox();
            this.labelCelciusToFahrenheit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOutputFtoC
            // 
            this.labelOutputFtoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputFtoC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputFtoC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputFtoC.Location = new System.Drawing.Point(466, 278);
            this.labelOutputFtoC.Name = "labelOutputFtoC";
            this.labelOutputFtoC.Size = new System.Drawing.Size(125, 23);
            this.labelOutputFtoC.TabIndex = 15;
            this.labelOutputFtoC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitFtoC
            // 
            this.buttonSubmitFtoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitFtoC.Location = new System.Drawing.Point(332, 277);
            this.buttonSubmitFtoC.Name = "buttonSubmitFtoC";
            this.buttonSubmitFtoC.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitFtoC.TabIndex = 14;
            this.buttonSubmitFtoC.Text = "Convert";
            this.buttonSubmitFtoC.UseVisualStyleBackColor = true;
            // 
            // textBoxFtoC
            // 
            this.textBoxFtoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFtoC.Location = new System.Drawing.Point(127, 278);
            this.textBoxFtoC.MaxLength = 6;
            this.textBoxFtoC.Name = "textBoxFtoC";
            this.textBoxFtoC.PlaceholderText = "Example: 98.6";
            this.textBoxFtoC.Size = new System.Drawing.Size(125, 23);
            this.textBoxFtoC.TabIndex = 13;
            // 
            // labelFtoC
            // 
            this.labelFtoC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFtoC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFtoC.Location = new System.Drawing.Point(229, 186);
            this.labelFtoC.Name = "labelFtoC";
            this.labelFtoC.Size = new System.Drawing.Size(178, 32);
            this.labelFtoC.TabIndex = 12;
            this.labelFtoC.Text = "Fahrenheit to Celcius";
            // 
            // labelOutputCtoF
            // 
            this.labelOutputCtoF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputCtoF.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputCtoF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputCtoF.Location = new System.Drawing.Point(466, 106);
            this.labelOutputCtoF.Name = "labelOutputCtoF";
            this.labelOutputCtoF.Size = new System.Drawing.Size(125, 23);
            this.labelOutputCtoF.TabIndex = 11;
            this.labelOutputCtoF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitCtoF
            // 
            this.buttonSubmitCtoF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitCtoF.Location = new System.Drawing.Point(332, 105);
            this.buttonSubmitCtoF.Name = "buttonSubmitCtoF";
            this.buttonSubmitCtoF.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitCtoF.TabIndex = 10;
            this.buttonSubmitCtoF.Text = "Convert";
            this.buttonSubmitCtoF.UseVisualStyleBackColor = true;
            // 
            // textBoxCtoF
            // 
            this.textBoxCtoF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCtoF.Location = new System.Drawing.Point(127, 106);
            this.textBoxCtoF.MaxLength = 6;
            this.textBoxCtoF.Name = "textBoxCtoF";
            this.textBoxCtoF.PlaceholderText = "Example: 37";
            this.textBoxCtoF.Size = new System.Drawing.Size(125, 23);
            this.textBoxCtoF.TabIndex = 9;
            // 
            // labelCelciusToFahrenheit
            // 
            this.labelCelciusToFahrenheit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCelciusToFahrenheit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCelciusToFahrenheit.Location = new System.Drawing.Point(229, 41);
            this.labelCelciusToFahrenheit.Name = "labelCelciusToFahrenheit";
            this.labelCelciusToFahrenheit.Size = new System.Drawing.Size(178, 32);
            this.labelCelciusToFahrenheit.TabIndex = 8;
            this.labelCelciusToFahrenheit.Text = "Celcius to Fahrenheit";
            // 
            // FormTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutputFtoC);
            this.Controls.Add(this.buttonSubmitFtoC);
            this.Controls.Add(this.textBoxFtoC);
            this.Controls.Add(this.labelFtoC);
            this.Controls.Add(this.labelOutputCtoF);
            this.Controls.Add(this.buttonSubmitCtoF);
            this.Controls.Add(this.textBoxCtoF);
            this.Controls.Add(this.labelCelciusToFahrenheit);
            this.Name = "FormTemperature";
            this.Text = "FormTemperature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutputFtoC;
        private System.Windows.Forms.Button buttonSubmitFtoC;
        private System.Windows.Forms.TextBox textBoxFtoC;
        private System.Windows.Forms.Label labelFtoC;
        private System.Windows.Forms.Label labelOutputCtoF;
        private System.Windows.Forms.Button buttonSubmitCtoF;
        private System.Windows.Forms.TextBox textBoxCtoF;
        private System.Windows.Forms.Label labelCelciusToFahrenheit;
    }
}