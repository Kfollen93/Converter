
namespace Converter.Forms
{
    partial class FormSpeed
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
            this.labelOutputMPHtoKMH = new System.Windows.Forms.Label();
            this.buttonSubmitMPHtoKMH = new System.Windows.Forms.Button();
            this.textBoxMPHtoKMH = new System.Windows.Forms.TextBox();
            this.labelMPHtoKMH = new System.Windows.Forms.Label();
            this.labelOutputKMHtoMPH = new System.Windows.Forms.Label();
            this.buttonSubmitKMHtoMPH = new System.Windows.Forms.Button();
            this.textBoxKMHtoMPH = new System.Windows.Forms.TextBox();
            this.labelKMHtoMPH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOutputMPHtoKMH
            // 
            this.labelOutputMPHtoKMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputMPHtoKMH.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputMPHtoKMH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputMPHtoKMH.Location = new System.Drawing.Point(476, 209);
            this.labelOutputMPHtoKMH.Name = "labelOutputMPHtoKMH";
            this.labelOutputMPHtoKMH.Size = new System.Drawing.Size(125, 23);
            this.labelOutputMPHtoKMH.TabIndex = 23;
            this.labelOutputMPHtoKMH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitMPHtoKMH
            // 
            this.buttonSubmitMPHtoKMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitMPHtoKMH.Location = new System.Drawing.Point(332, 209);
            this.buttonSubmitMPHtoKMH.Name = "buttonSubmitMPHtoKMH";
            this.buttonSubmitMPHtoKMH.Size = new System.Drawing.Size(125, 23);
            this.buttonSubmitMPHtoKMH.TabIndex = 22;
            this.buttonSubmitMPHtoKMH.Text = "Convert";
            this.buttonSubmitMPHtoKMH.UseVisualStyleBackColor = true;
            this.buttonSubmitMPHtoKMH.Click += new System.EventHandler(this.buttonSubmitMPHtoKMH_Click);
            // 
            // textBoxMPHtoKMH
            // 
            this.textBoxMPHtoKMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMPHtoKMH.Location = new System.Drawing.Point(188, 209);
            this.textBoxMPHtoKMH.MaxLength = 6;
            this.textBoxMPHtoKMH.Name = "textBoxMPHtoKMH";
            this.textBoxMPHtoKMH.PlaceholderText = "Example: 95.5";
            this.textBoxMPHtoKMH.Size = new System.Drawing.Size(125, 23);
            this.textBoxMPHtoKMH.TabIndex = 21;
            // 
            // labelMPHtoKMH
            // 
            this.labelMPHtoKMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMPHtoKMH.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMPHtoKMH.ForeColor = System.Drawing.Color.White;
            this.labelMPHtoKMH.Location = new System.Drawing.Point(339, 165);
            this.labelMPHtoKMH.Name = "labelMPHtoKMH";
            this.labelMPHtoKMH.Size = new System.Drawing.Size(178, 32);
            this.labelMPHtoKMH.TabIndex = 20;
            this.labelMPHtoKMH.Text = "MPH to KMH";
            // 
            // labelOutputKMHtoMPH
            // 
            this.labelOutputKMHtoMPH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputKMHtoMPH.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelOutputKMHtoMPH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputKMHtoMPH.Location = new System.Drawing.Point(476, 123);
            this.labelOutputKMHtoMPH.Name = "labelOutputKMHtoMPH";
            this.labelOutputKMHtoMPH.Size = new System.Drawing.Size(125, 23);
            this.labelOutputKMHtoMPH.TabIndex = 19;
            this.labelOutputKMHtoMPH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmitKMHtoMPH
            // 
            this.buttonSubmitKMHtoMPH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitKMHtoMPH.Location = new System.Drawing.Point(332, 123);
            this.buttonSubmitKMHtoMPH.Name = "buttonSubmitKMHtoMPH";
            this.buttonSubmitKMHtoMPH.Size = new System.Drawing.Size(125, 23);
            this.buttonSubmitKMHtoMPH.TabIndex = 18;
            this.buttonSubmitKMHtoMPH.Text = "Convert";
            this.buttonSubmitKMHtoMPH.UseVisualStyleBackColor = true;
            this.buttonSubmitKMHtoMPH.Click += new System.EventHandler(this.buttonSubmitKMHtoMPH_Click);
            // 
            // textBoxKMHtoMPH
            // 
            this.textBoxKMHtoMPH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxKMHtoMPH.Location = new System.Drawing.Point(188, 123);
            this.textBoxKMHtoMPH.MaxLength = 6;
            this.textBoxKMHtoMPH.Name = "textBoxKMHtoMPH";
            this.textBoxKMHtoMPH.PlaceholderText = "Example: 60";
            this.textBoxKMHtoMPH.Size = new System.Drawing.Size(125, 23);
            this.textBoxKMHtoMPH.TabIndex = 17;
            // 
            // labelKMHtoMPH
            // 
            this.labelKMHtoMPH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKMHtoMPH.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelKMHtoMPH.ForeColor = System.Drawing.Color.White;
            this.labelKMHtoMPH.Location = new System.Drawing.Point(339, 77);
            this.labelKMHtoMPH.Name = "labelKMHtoMPH";
            this.labelKMHtoMPH.Size = new System.Drawing.Size(178, 32);
            this.labelKMHtoMPH.TabIndex = 16;
            this.labelKMHtoMPH.Text = "KMH to MPH";
            // 
            // FormSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutputMPHtoKMH);
            this.Controls.Add(this.buttonSubmitMPHtoKMH);
            this.Controls.Add(this.textBoxMPHtoKMH);
            this.Controls.Add(this.labelMPHtoKMH);
            this.Controls.Add(this.labelOutputKMHtoMPH);
            this.Controls.Add(this.buttonSubmitKMHtoMPH);
            this.Controls.Add(this.textBoxKMHtoMPH);
            this.Controls.Add(this.labelKMHtoMPH);
            this.Name = "FormSpeed";
            this.Text = "FormSpeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOutputMPHtoKMH;
        private System.Windows.Forms.Button buttonSubmitMPHtoKMH;
        private System.Windows.Forms.TextBox textBoxMPHtoKMH;
        private System.Windows.Forms.Label labelMPHtoKMH;
        private System.Windows.Forms.Label labelOutputKMHtoMPH;
        private System.Windows.Forms.Button buttonSubmitKMHtoMPH;
        private System.Windows.Forms.TextBox textBoxKMHtoMPH;
        private System.Windows.Forms.Label labelKMHtoMPH;
    }
}