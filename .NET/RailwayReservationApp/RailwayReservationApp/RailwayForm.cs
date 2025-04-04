using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RailwayReservationApp
{
    public partial class RailwayForm : Form
    {
        public RailwayForm()
        {
            InitializeComponent();
        }

        private void RailwayForm_Load(object sender, EventArgs e)
        {
            
            textBoxName.Enabled = true;
            comboBoxFrom.Enabled = true;
            comboBoxTo.Enabled = true;
            numericUpDownNoOfPassengers.Enabled = true;
            comboBoxClass.Enabled = true;
            buttonSubmit.Enabled = true;
            labelMessage.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                ShowError("Please enter your full name.");
                return;
            }

           
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)
            {
                ShowError("Please select both From and To locations.");
                return;
            }

            if (comboBoxFrom.SelectedItem.ToString() == comboBoxTo.SelectedItem.ToString())
            {
                ShowError("From and To locations must be different.");
                return;
            }

            
            if (dateTimePickerDeparture.Value.Date < DateTime.Now.Date)
            {
                ShowError("Departure date must be today or later.");
                return;
            }

           
            if (numericUpDownNoOfPassengers.Value < 1)
            {
                ShowError("Please enter at least 1 passenger.");
                return;
            }

            if (comboBoxClass.SelectedItem == null)
            {
                ShowError("Please select a travel class.");
                return;
            }

            
            labelMessage.ForeColor = System.Drawing.Color.Green;
            labelMessage.Text = $"Ticket Booked!\nName: {textBoxName.Text}\n" +
            $"From: {comboBoxFrom.SelectedItem}\n" +
                                $"To: {comboBoxTo.SelectedItem}\n" +
                                $"Departure: {dateTimePickerDeparture.Value.ToShortDateString()}\n" +
                                $"Passengers: {numericUpDownNoOfPassengers.Value}\n" +
                                $"Class: {comboBoxClass.SelectedItem}";
        }

        private void ShowError(string message)
        {
            labelMessage.ForeColor = System.Drawing.Color.Red;
            labelMessage.Text = message;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            comboBoxFrom.SelectedItem = null;
            comboBoxTo.SelectedItem = null;
            dateTimePickerDeparture.Value = DateTime.Now;
            numericUpDownNoOfPassengers.Value = 1;
            comboBoxClass.SelectedItem = null;
            labelMessage.Text = "";
        }
    }
}