using System;
using System.Windows.Forms;

namespace HospitalOPDApp
{
    public partial class HospitalOPDForm : Form
    {
        public HospitalOPDForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxAge.Text) ||
                string.IsNullOrEmpty(textBoxContact.Text) || comboBoxDepartment.SelectedItem == null)
            {
                labelMessage.ForeColor = System.Drawing.Color.Red;
                labelMessage.Text = "Please fill in all required fields!";
                return;
            }

            // Get Gender
            string gender = radioButtonMale.Checked ? "Male" :
                            radioButtonFemale.Checked ? "Female" : "Other";

            // Show Confirmation
            labelMessage.ForeColor = System.Drawing.Color.Green;
            labelMessage.Text = $"Registration Successful!\nName: {textBoxName.Text}\nGender: {gender}\n" +
                                $"Department: {comboBoxDepartment.SelectedItem}\nAppointment: {dateTimePickerAppointment.Value.ToShortDateString()}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxContact.Clear();
            textBoxAddress.Clear();
            textBoxSymptoms.Clear();
            radioButtonMale.Checked = radioButtonFemale.Checked = radioButtonOther.Checked = false;
            comboBoxDepartment.SelectedIndex = -1;
            dateTimePickerAppointment.Value = DateTime.Now;
            labelMessage.Text = "";
        }
    }
}
