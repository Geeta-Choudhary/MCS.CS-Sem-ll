 namespace Todo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set ToolTips using the instance created in the UI
            toolTip1.SetToolTip(btnAddTask, "Click to add a new task.");
            toolTip1.SetToolTip(btnClear, "Click to clear all tasks.");
            toolTip1.SetToolTip(btnDelete, "Click to delete the selected task.");
            toolTip1.SetToolTip(btnFinished, "Click to mark the selected task as finished.");

        }


        // Hover effect for Add Task button
        private void btnAddTask_MouseEnter(object sender, EventArgs e)
        {
            btnAddTask.BackColor = Color.DarkGreen; // Hover color
        }

        private void btnAddTask_MouseLeave(object sender, EventArgs e)
        {
            btnAddTask.BackColor = Color.LightGreen; // Normal color
        }

        // Button click event for adding a task
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text)) // Check if task is not empty
            {
                lstTasks.Items.Add(txtTask.Text);  // Add task to ListBox
                txtTask.Clear();                   // Clear the input field
            }
            else
            {
                MessageBox.Show("Please enter a task.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hover effect for Clear button
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DarkRed; // Hover color
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.LightCoral; // Normal color
        }

        // Button click event for clearing all tasks
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstTasks.Items.Count > 0) // Check if there are tasks to clear
            {
                lstTasks.Items.Clear(); // Clear all tasks from the ListBox
            }
            else
            {
                MessageBox.Show("No tasks to clear.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Hover effect for Delete button
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.DarkOrange; // Hover color
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightSalmon; // Normal color
        }

        // Button click event for deleting the selected task
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) // Check if an item is selected
            {
                lstTasks.Items.Remove(lstTasks.SelectedItem); // Remove the selected task
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hover effect for Finished button
        private void btnFinished_MouseEnter(object sender, EventArgs e)
        {
            btnFinished.BackColor = Color.DarkBlue; // Hover color
        }

        private void btnFinished_MouseLeave(object sender, EventArgs e)
        {
            btnFinished.BackColor = Color.LightSkyBlue; // Normal color
        }

        // Button click event for marking a task as finished
        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null) // Check if an item is selected
            {
                int selectedIndex = lstTasks.SelectedIndex;
                string task = lstTasks.SelectedItem.ToString();

                // Check if the task is already marked as completed
                if (!task.StartsWith("✔️"))
                {
                    lstTasks.Items[selectedIndex] = "✔️ " + task; // Add tick mark at the beginning
                }
                else
                {
                    MessageBox.Show("Task is already marked as finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as finished.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
