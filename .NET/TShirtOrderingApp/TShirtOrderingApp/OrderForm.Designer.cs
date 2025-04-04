namespace TShirtOrderingApp
{
    partial class OrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.lblPromo = new System.Windows.Forms.Label();
            this.txtPromoCode = new System.Windows.Forms.TextBox();  // Corrected name
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(243, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of T-shirts";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            this.label2.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(633, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "T-Shirt Ordering App";

            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtQuantity.Location = new System.Drawing.Point(470, 92);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(398, 48);
            this.txtQuantity.TabIndex = 2;

            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
            this.grpSize.Location = new System.Drawing.Point(470, 168);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(428, 181);
            this.grpSize.TabIndex = 3;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Select T-shirt size";

            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(272, 240);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(159, 24);
            this.rbMedium.TabIndex = 4;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium (Rs. 175)";
            this.rbMedium.UseVisualStyleBackColor = true;

            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(272, 308);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(144, 24);
            this.rbLarge.TabIndex = 5;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large (Rs. 250)";
            this.rbLarge.UseVisualStyleBackColor = true;

            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(272, 168);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(142, 24);
            this.rbSmall.TabIndex = 6;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (Rs. 125)";
            this.rbSmall.UseVisualStyleBackColor = true;

            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.BackColor = System.Drawing.SystemColors.Info;
            this.lblPromo.Location = new System.Drawing.Point(291, 397);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(137, 20);
            this.lblPromo.TabIndex = 7;
            this.lblPromo.Text = "Enter Promo Code";

            // 
            // txtPromoCode
            // 
            this.txtPromoCode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPromoCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPromoCode.Location = new System.Drawing.Point(470, 394);
            this.txtPromoCode.Multiline = true;
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.Size = new System.Drawing.Size(422, 51);
            this.txtPromoCode.TabIndex = 8;

            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.lblFinalPrice.Location = new System.Drawing.Point(279, 499);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(137, 20);
            this.lblFinalPrice.TabIndex = 9;
            this.lblFinalPrice.Text = "Final Price: Rs. 0.00";

            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCalculate.Location = new System.Drawing.Point(470, 486);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(178, 73);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click); // Added event handler

            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 602);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.rbSmall);
            this.Controls.Add(this.rbLarge);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm"; // Fixed naming issue
            this.Text = "T-Shirt Ordering Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1, label2, lblPromo, lblFinalPrice;
        private System.Windows.Forms.TextBox txtQuantity, txtPromoCode;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rbMedium, rbLarge, rbSmall;
        private System.Windows.Forms.Button btnCalculate;
    }
}
