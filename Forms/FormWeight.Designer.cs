
namespace Converter.Forms
{
    partial class FormWeight
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
            this.labelWeightForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWeightForm
            // 
            this.labelWeightForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWeightForm.AutoSize = true;
            this.labelWeightForm.Location = new System.Drawing.Point(310, 67);
            this.labelWeightForm.Name = "labelWeightForm";
            this.labelWeightForm.Size = new System.Drawing.Size(117, 15);
            this.labelWeightForm.TabIndex = 0;
            this.labelWeightForm.Text = "Kilograms to Pounds";
            // 
            // FormWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWeightForm);
            this.Name = "FormWeight";
            this.Text = "FormWeight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeightForm;
    }
}