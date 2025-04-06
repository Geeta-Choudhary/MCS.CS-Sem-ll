namespace College_Fest_Event_Handling
{
    partial class CollegeFestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtVisitors;
        private System.Windows.Forms.Button btnOrganizeFest;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblVisitors;
        private System.Windows.Forms.Label lblOutput;

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
            this.txtVisitors = new System.Windows.Forms.TextBox();
            this.btnOrganizeFest = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVisitors
            // 
            this.lblVisitors.AutoSize = true;
            this.lblVisitors.Location = new System.Drawing.Point(30, 10);
            this.lblVisitors.Name = "lblVisitors";
            this.lblVisitors.Size = new System.Drawing.Size(160, 17);
            this.lblVisitors.Text = "Enter number of visitors:";
            // 
            // txtVisitors
            // 
            this.txtVisitors.Location = new System.Drawing.Point(30, 30);
            this.txtVisitors.Name = "txtVisitors";
            this.txtVisitors.Size = new System.Drawing.Size(200, 22);
            // 
            // btnOrganizeFest
            // 
            this.btnOrganizeFest.Location = new System.Drawing.Point(30, 70);
            this.btnOrganizeFest.Name = "btnOrganizeFest";
            this.btnOrganizeFest.Size = new System.Drawing.Size(200, 30);
            this.btnOrganizeFest.Text = "Organize Fest";
            this.btnOrganizeFest.Click += new System.EventHandler(this.btnOrganizeFest_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(30, 110);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(119, 17);
            this.lblOutput.Text = "Fest Expense Bill:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 130);
            this.txtOutput.Multiline = true;
            this.txtOutput.Size = new System.Drawing.Size(300, 100);
            // 
            // CollegeFestForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblVisitors);
            this.Controls.Add(this.txtVisitors);
            this.Controls.Add(this.btnOrganizeFest);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Text = "College Fest Event Handling";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
