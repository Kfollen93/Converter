
namespace Converter.Forms
{
    partial class FormLength
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
            this.labelOutputInchesToCM = new System.Windows.Forms.Label();
            this.buttonSubmitInchesToCM = new System.Windows.Forms.Button();
            this.textBoxInchesToCM = new System.Windows.Forms.TextBox();
            this.labelInchToCM = new System.Windows.Forms.Label();
            this.labelOutputCMtoInches = new System.Windows.Forms.Label();
            this.buttonSubmitCMtoInches = new System.Windows.Forms.Button();
            this.textBoxCMtoInches = new System.Windows.Forms.TextBox();
            this.labelCMtoInch = new System.Windows.Forms.Label();
            this.labelOutputFeetToMeters = new System.Windows.Forms.Label();
            this.buttonSubmitFeetToMeters = new System.Windows.Forms.Button();
            this.textBoxFeetToMeters = new System.Windows.Forms.TextBox();
            this.labelFeetToMeters = new System.Windows.Forms.Label();
            this.labelOutputMetersToFeet = new System.Windows.Forms.Label();
            this.buttonSubmitMetersToFeet = new System.Windows.Forms.Button();
            this.textBoxMetersToFeet = new System.Windows.Forms.TextBox();
            this.labelMetersToFeet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOutputInchesToCM
            // 
            this.labelOutputInchesToCM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputInchesToCM.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputInchesToCM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputInchesToCM.Location = new System.Drawing.Point(466, 165);
            this.labelOutputInchesToCM.Name = "labelOutputInchesToCM";
            this.labelOutputInchesToCM.Size = new System.Drawing.Size(125, 23);
            this.labelOutputInchesToCM.TabIndex = 23;
            this.labelOutputInchesToCM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitInchesToCM
            // 
            this.buttonSubmitInchesToCM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitInchesToCM.Location = new System.Drawing.Point(332, 164);
            this.buttonSubmitInchesToCM.Name = "buttonSubmitInchesToCM";
            this.buttonSubmitInchesToCM.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitInchesToCM.TabIndex = 22;
            this.buttonSubmitInchesToCM.Text = "Convert";
            this.buttonSubmitInchesToCM.UseVisualStyleBackColor = true;
            this.buttonSubmitInchesToCM.Click += new System.EventHandler(this.buttonSubmitInchesToCM_Click);
            // 
            // textBoxInchesToCM
            // 
            this.textBoxInchesToCM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxInchesToCM.Location = new System.Drawing.Point(127, 164);
            this.textBoxInchesToCM.MaxLength = 6;
            this.textBoxInchesToCM.Name = "textBoxInchesToCM";
            this.textBoxInchesToCM.PlaceholderText = "Example: 0.39";
            this.textBoxInchesToCM.Size = new System.Drawing.Size(125, 23);
            this.textBoxInchesToCM.TabIndex = 21;
            // 
            // labelInchToCM
            // 
            this.labelInchToCM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInchToCM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInchToCM.Location = new System.Drawing.Point(229, 115);
            this.labelInchToCM.Name = "labelInchToCM";
            this.labelInchToCM.Size = new System.Drawing.Size(178, 32);
            this.labelInchToCM.TabIndex = 20;
            this.labelInchToCM.Text = "Inches to Centimeters";
            // 
            // labelOutputCMtoInches
            // 
            this.labelOutputCMtoInches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputCMtoInches.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputCMtoInches.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputCMtoInches.Location = new System.Drawing.Point(466, 75);
            this.labelOutputCMtoInches.Name = "labelOutputCMtoInches";
            this.labelOutputCMtoInches.Size = new System.Drawing.Size(125, 23);
            this.labelOutputCMtoInches.TabIndex = 19;
            this.labelOutputCMtoInches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitCMtoInches
            // 
            this.buttonSubmitCMtoInches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitCMtoInches.Location = new System.Drawing.Point(332, 74);
            this.buttonSubmitCMtoInches.Name = "buttonSubmitCMtoInches";
            this.buttonSubmitCMtoInches.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitCMtoInches.TabIndex = 18;
            this.buttonSubmitCMtoInches.Text = "Convert";
            this.buttonSubmitCMtoInches.UseVisualStyleBackColor = true;
            this.buttonSubmitCMtoInches.Click += new System.EventHandler(this.buttonSubmitCMtoInches_Click);
            // 
            // textBoxCMtoInches
            // 
            this.textBoxCMtoInches.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxCMtoInches.Location = new System.Drawing.Point(127, 74);
            this.textBoxCMtoInches.MaxLength = 6;
            this.textBoxCMtoInches.Name = "textBoxCMtoInches";
            this.textBoxCMtoInches.PlaceholderText = "Example: 1";
            this.textBoxCMtoInches.Size = new System.Drawing.Size(125, 23);
            this.textBoxCMtoInches.TabIndex = 17;
            // 
            // labelCMtoInch
            // 
            this.labelCMtoInch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCMtoInch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCMtoInch.Location = new System.Drawing.Point(229, 29);
            this.labelCMtoInch.Name = "labelCMtoInch";
            this.labelCMtoInch.Size = new System.Drawing.Size(178, 32);
            this.labelCMtoInch.TabIndex = 16;
            this.labelCMtoInch.Text = "Centimeters to Inches";
            // 
            // labelOutputFeetToMeters
            // 
            this.labelOutputFeetToMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputFeetToMeters.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputFeetToMeters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputFeetToMeters.Location = new System.Drawing.Point(466, 338);
            this.labelOutputFeetToMeters.Name = "labelOutputFeetToMeters";
            this.labelOutputFeetToMeters.Size = new System.Drawing.Size(125, 23);
            this.labelOutputFeetToMeters.TabIndex = 31;
            this.labelOutputFeetToMeters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitFeetToMeters
            // 
            this.buttonSubmitFeetToMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitFeetToMeters.Location = new System.Drawing.Point(332, 337);
            this.buttonSubmitFeetToMeters.Name = "buttonSubmitFeetToMeters";
            this.buttonSubmitFeetToMeters.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitFeetToMeters.TabIndex = 30;
            this.buttonSubmitFeetToMeters.Text = "Convert";
            this.buttonSubmitFeetToMeters.UseVisualStyleBackColor = true;
            this.buttonSubmitFeetToMeters.Click += new System.EventHandler(this.buttonSubmitFeetToMeters_Click);
            // 
            // textBoxFeetToMeters
            // 
            this.textBoxFeetToMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxFeetToMeters.Location = new System.Drawing.Point(127, 338);
            this.textBoxFeetToMeters.MaxLength = 6;
            this.textBoxFeetToMeters.Name = "textBoxFeetToMeters";
            this.textBoxFeetToMeters.PlaceholderText = "Example: 3.28";
            this.textBoxFeetToMeters.Size = new System.Drawing.Size(125, 23);
            this.textBoxFeetToMeters.TabIndex = 29;
            // 
            // labelFeetToMeters
            // 
            this.labelFeetToMeters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFeetToMeters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFeetToMeters.Location = new System.Drawing.Point(229, 289);
            this.labelFeetToMeters.Name = "labelFeetToMeters";
            this.labelFeetToMeters.Size = new System.Drawing.Size(178, 32);
            this.labelFeetToMeters.TabIndex = 28;
            this.labelFeetToMeters.Text = "Feet To Meters";
            // 
            // labelOutputMetersToFeet
            // 
            this.labelOutputMetersToFeet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputMetersToFeet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputMetersToFeet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputMetersToFeet.Location = new System.Drawing.Point(466, 248);
            this.labelOutputMetersToFeet.Name = "labelOutputMetersToFeet";
            this.labelOutputMetersToFeet.Size = new System.Drawing.Size(125, 23);
            this.labelOutputMetersToFeet.TabIndex = 27;
            this.labelOutputMetersToFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitMetersToFeet
            // 
            this.buttonSubmitMetersToFeet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitMetersToFeet.Location = new System.Drawing.Point(332, 247);
            this.buttonSubmitMetersToFeet.Name = "buttonSubmitMetersToFeet";
            this.buttonSubmitMetersToFeet.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitMetersToFeet.TabIndex = 26;
            this.buttonSubmitMetersToFeet.Text = "Convert";
            this.buttonSubmitMetersToFeet.UseVisualStyleBackColor = true;
            this.buttonSubmitMetersToFeet.Click += new System.EventHandler(this.buttonSubmitMetersToFeet_Click);
            // 
            // textBoxMetersToFeet
            // 
            this.textBoxMetersToFeet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMetersToFeet.Location = new System.Drawing.Point(127, 248);
            this.textBoxMetersToFeet.MaxLength = 6;
            this.textBoxMetersToFeet.Name = "textBoxMetersToFeet";
            this.textBoxMetersToFeet.PlaceholderText = "Example: 1";
            this.textBoxMetersToFeet.Size = new System.Drawing.Size(125, 23);
            this.textBoxMetersToFeet.TabIndex = 25;
            // 
            // labelMetersToFeet
            // 
            this.labelMetersToFeet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMetersToFeet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMetersToFeet.Location = new System.Drawing.Point(229, 203);
            this.labelMetersToFeet.Name = "labelMetersToFeet";
            this.labelMetersToFeet.Size = new System.Drawing.Size(178, 32);
            this.labelMetersToFeet.TabIndex = 24;
            this.labelMetersToFeet.Text = "Meters to Feet";
            // 
            // FormLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutputFeetToMeters);
            this.Controls.Add(this.buttonSubmitFeetToMeters);
            this.Controls.Add(this.textBoxFeetToMeters);
            this.Controls.Add(this.labelFeetToMeters);
            this.Controls.Add(this.labelOutputMetersToFeet);
            this.Controls.Add(this.buttonSubmitMetersToFeet);
            this.Controls.Add(this.textBoxMetersToFeet);
            this.Controls.Add(this.labelMetersToFeet);
            this.Controls.Add(this.labelOutputInchesToCM);
            this.Controls.Add(this.buttonSubmitInchesToCM);
            this.Controls.Add(this.textBoxInchesToCM);
            this.Controls.Add(this.labelInchToCM);
            this.Controls.Add(this.labelOutputCMtoInches);
            this.Controls.Add(this.buttonSubmitCMtoInches);
            this.Controls.Add(this.textBoxCMtoInches);
            this.Controls.Add(this.labelCMtoInch);
            this.Name = "FormLength";
            this.Text = "FormLength";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutputInchesToCM;
        private System.Windows.Forms.Button buttonSubmitInchesToCM;
        private System.Windows.Forms.TextBox textBoxInchesToCM;
        private System.Windows.Forms.Label labelInchToCM;
        private System.Windows.Forms.Label labelOutputCMtoInches;
        private System.Windows.Forms.Button buttonSubmitCMtoInches;
        private System.Windows.Forms.TextBox textBoxCMtoInches;
        private System.Windows.Forms.Label labelCMtoInch;
        private System.Windows.Forms.Label labelOutputFeetToMeters;
        private System.Windows.Forms.Button buttonSubmitFeetToMeters;
        private System.Windows.Forms.TextBox textBoxFeetToMeters;
        private System.Windows.Forms.Label labelFeetToMeters;
        private System.Windows.Forms.Label labelOutputMetersToFeet;
        private System.Windows.Forms.Button buttonSubmitMetersToFeet;
        private System.Windows.Forms.TextBox textBoxMetersToFeet;
        private System.Windows.Forms.Label labelMetersToFeet;
    }
}