namespace TShirtOrderingApp
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnOrderForm;
        private System.Windows.Forms.Button btnCalculatorForm;
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

        private void InitializeComponent()
        {
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnCalculatorForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrderForm.Location = new System.Drawing.Point(171, 64);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(358, 72);
            this.btnOrderForm.TabIndex = 0;
            this.btnOrderForm.Text = "Open T-Shirt Order Form";
            this.btnOrderForm.UseVisualStyleBackColor = false;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);  // Event handler
            // 
            // btnCalculatorForm
            // 
            this.btnCalculatorForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalculatorForm.Location = new System.Drawing.Point(183, 227);
            this.btnCalculatorForm.Name = "btnCalculatorForm";
            this.btnCalculatorForm.Size = new System.Drawing.Size(346, 65);
            this.btnCalculatorForm.TabIndex = 1;
            this.btnCalculatorForm.Text = "Open Calculator Form";
            this.btnCalculatorForm.UseVisualStyleBackColor = false;
            this.btnCalculatorForm.Click += new System.EventHandler(this.btnCalculatorForm_Click);  // Event handler
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculatorForm);
            this.Controls.Add(this.btnOrderForm);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu Form";
            this.ResumeLayout(false);
        }
    }
} 


 