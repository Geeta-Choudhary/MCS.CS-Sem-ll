namespace HospitalOPDApp
{
    partial class HospitalOPDForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Title Label
            this.labelTitle.Text = "Hospital OPD Registration Form";
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Location = new System.Drawing.Point(100, 20);
            this.labelTitle.Size = new System.Drawing.Size(350, 30);

            // Name Label
            this.labelName.Text = "Full Name:";
            this.labelName.Location = new System.Drawing.Point(30, 70);
            this.labelName.Font = new System.Drawing.Font("Arial", 10F);
            this.labelName.Size = new System.Drawing.Size(100, 20);

            // Name TextBox
            this.textBoxName.Location = new System.Drawing.Point(150, 70);
            this.textBoxName.Size = new System.Drawing.Size(250, 26);

            // DOB Label
            this.labelDOB.Text = "Date of Birth:";
            this.labelDOB.Location = new System.Drawing.Point(30, 110);
            this.labelDOB.Font = new System.Drawing.Font("Arial", 10F);
            this.labelDOB.Size = new System.Drawing.Size(100, 20);

            // DOB Picker
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(150, 110);
            this.dateTimePickerDOB.Size = new System.Drawing.Size(250, 26);

            // Gender Label
            this.labelGender.Text = "Gender:";
            this.labelGender.Location = new System.Drawing.Point(30, 150);
            this.labelGender.Font = new System.Drawing.Font("Arial", 10F);
            this.labelGender.Size = new System.Drawing.Size(100, 20);

            // Gender Radio Buttons
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.Location = new System.Drawing.Point(150, 150);
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.Location = new System.Drawing.Point(220, 150);
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.Location = new System.Drawing.Point(290, 150);

            // Mobile Number Label
            this.labelMobile.Text = "Mobile No:";
            this.labelMobile.Location = new System.Drawing.Point(30, 190);
            this.labelMobile.Font = new System.Drawing.Font("Arial", 10F);
            this.labelMobile.Size = new System.Drawing.Size(100, 20);

            // Mobile TextBox
            this.textBoxMobile.Location = new System.Drawing.Point(150, 190);
            this.textBoxMobile.Size = new System.Drawing.Size(250, 26);

            // Department Label
            this.labelDepartment.Text = "Department:";
            this.labelDepartment.Location = new System.Drawing.Point(30, 230);
            this.labelDepartment.Font = new System.Drawing.Font("Arial", 10F);
            this.labelDepartment.Size = new System.Drawing.Size(100, 20);

            // Department ComboBox
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.Items.AddRange(new object[] {
                "General Medicine",
                "Pediatrics",
                "Orthopedics",
                "Cardiology",
                "Neurology"
            });
            this.comboBoxDepartment.Location = new System.Drawing.Point(150, 230);
            this.comboBoxDepartment.Size = new System.Drawing.Size(250, 28);

            // Submit Button
            this.buttonSubmit.Text = "Register";
            this.buttonSubmit.Location = new System.Drawing.Point(150, 280);
            this.buttonSubmit.Size = new System.Drawing.Size(100, 30);
            this.buttonSubmit.BackColor = System.Drawing.Color.Green;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            // Clear Button
            this.buttonClear.Text = "Clear";
            this.buttonClear.Location = new System.Drawing.Point(300, 280);
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // Message Label
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(30, 320);
            this.labelMessage.Font = new System.Drawing.Font("Arial", 10F);
            this.labelMessage.ForeColor = System.Drawing.Color.Red;

            // Adding Controls
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonOther);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMessage);

            // Form Settings
            this.Text = "Hospital OPD Registration";
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
