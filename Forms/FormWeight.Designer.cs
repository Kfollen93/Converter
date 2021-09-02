
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
            this.labelKGtoPounds = new System.Windows.Forms.Label();
            this.textBoxKGtoPounds = new System.Windows.Forms.TextBox();
            this.buttonSubmitKGtoPounds = new System.Windows.Forms.Button();
            this.labelOutputKGtoPounds = new System.Windows.Forms.Label();
            this.labelPoundsToKG = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSubmitPoundstoKG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKGtoPounds
            // 
            this.labelKGtoPounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelKGtoPounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKGtoPounds.Location = new System.Drawing.Point(229, 41);
            this.labelKGtoPounds.Name = "labelKGtoPounds";
            this.labelKGtoPounds.Size = new System.Drawing.Size(178, 32);
            this.labelKGtoPounds.TabIndex = 0;
            this.labelKGtoPounds.Text = "Kilograms to Pounds";
            // 
            // textBoxKGtoPounds
            // 
            this.textBoxKGtoPounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxKGtoPounds.Location = new System.Drawing.Point(127, 106);
            this.textBoxKGtoPounds.MaxLength = 8;
            this.textBoxKGtoPounds.Name = "textBoxKGtoPounds";
            this.textBoxKGtoPounds.Size = new System.Drawing.Size(125, 23);
            this.textBoxKGtoPounds.TabIndex = 1;
            // 
            // buttonSubmitKGtoPounds
            // 
            this.buttonSubmitKGtoPounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitKGtoPounds.Location = new System.Drawing.Point(332, 105);
            this.buttonSubmitKGtoPounds.Name = "buttonSubmitKGtoPounds";
            this.buttonSubmitKGtoPounds.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitKGtoPounds.TabIndex = 2;
            this.buttonSubmitKGtoPounds.Text = "Convert";
            this.buttonSubmitKGtoPounds.UseVisualStyleBackColor = true;
            this.buttonSubmitKGtoPounds.Click += new System.EventHandler(this.buttonSubmitKGtoPounds_Click);
            // 
            // labelOutputKGtoPounds
            // 
            this.labelOutputKGtoPounds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOutputKGtoPounds.BackColor = System.Drawing.Color.Lime;
            this.labelOutputKGtoPounds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputKGtoPounds.Location = new System.Drawing.Point(466, 106);
            this.labelOutputKGtoPounds.Name = "labelOutputKGtoPounds";
            this.labelOutputKGtoPounds.Size = new System.Drawing.Size(60, 30);
            this.labelOutputKGtoPounds.TabIndex = 3;
            this.labelOutputKGtoPounds.Text = "Output";
            this.labelOutputKGtoPounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoundsToKG
            // 
            this.labelPoundsToKG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPoundsToKG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPoundsToKG.Location = new System.Drawing.Point(229, 186);
            this.labelPoundsToKG.Name = "labelPoundsToKG";
            this.labelPoundsToKG.Size = new System.Drawing.Size(178, 32);
            this.labelPoundsToKG.TabIndex = 4;
            this.labelPoundsToKG.Text = "Pounds to Kilograms";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(127, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 23);
            this.textBox1.TabIndex = 5;
            // 
            // buttonSubmitPoundstoKG
            // 
            this.buttonSubmitPoundstoKG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSubmitPoundstoKG.Location = new System.Drawing.Point(332, 277);
            this.buttonSubmitPoundstoKG.Name = "buttonSubmitPoundstoKG";
            this.buttonSubmitPoundstoKG.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitPoundstoKG.TabIndex = 6;
            this.buttonSubmitPoundstoKG.Text = "Convert";
            this.buttonSubmitPoundstoKG.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(466, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(100)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmitPoundstoKG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPoundsToKG);
            this.Controls.Add(this.labelOutputKGtoPounds);
            this.Controls.Add(this.buttonSubmitKGtoPounds);
            this.Controls.Add(this.textBoxKGtoPounds);
            this.Controls.Add(this.labelKGtoPounds);
            this.Name = "FormWeight";
            this.Text = "FormWeight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKGtoPounds;
        private System.Windows.Forms.TextBox textBoxKGtoPounds;
        private System.Windows.Forms.Button buttonSubmitKGtoPounds;
        private System.Windows.Forms.Label labelOutputKGtoPounds;
        private System.Windows.Forms.Label labelPoundsToKG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSubmitPoundstoKG;
        private System.Windows.Forms.Label label1;
    }
}