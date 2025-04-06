namespace Todo_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTask = new TextBox();
            label1 = new Label();
            lstTasks = new ListBox();
            btnAddTask = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnFinished = new Button();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.BackColor = Color.LightCyan;
            txtTask.Font = new Font("Arial", 12F);
            txtTask.ForeColor = Color.DarkBlue;
            txtTask.Location = new Point(249, 85);
            txtTask.Multiline = true;
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(452, 46);
            txtTask.TabIndex = 0;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(62, 88);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter the Task Name :";
            // 
            // lstTasks
            // 
            lstTasks.BackColor = Color.LightYellow;
            lstTasks.Font = new Font("Arial", 10F);
            lstTasks.ForeColor = Color.DarkSlateGray;
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 23;
            lstTasks.Location = new Point(249, 167);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(796, 441);
            lstTasks.TabIndex = 13;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.LightGreen;
            btnAddTask.Font = new Font("Arial", 12F);
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(337, 655);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(112, 34);
            btnAddTask.TabIndex = 14;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            btnAddTask.MouseEnter += btnAddTask_MouseEnter;
            btnAddTask.MouseLeave += btnAddTask_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightCyan;
            btnClear.Font = new Font("Microsoft Sans Serif", 10F);
            btnClear.Location = new Point(525, 655);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Arial", 10F);
            btnDelete.Location = new Point(699, 655);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Remove";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseEnter += btnDelete_MouseEnter;
            btnDelete.MouseLeave += btnDelete_MouseLeave;
            // 
            // btnFinished
            // 
            btnFinished.BackColor = Color.LightGreen;
            btnFinished.Font = new Font("Microsoft Sans Serif", 10F);
            btnFinished.Location = new Point(870, 655);
            btnFinished.Name = "btnFinished";
            btnFinished.Size = new Size(112, 34);
            btnFinished.TabIndex = 17;
            btnFinished.Text = "Finished";
            btnFinished.UseVisualStyleBackColor = false;
            btnFinished.Click += btnFinished_Click;
            btnFinished.MouseEnter += btnFinished_MouseEnter;
            btnFinished.MouseLeave += btnFinished_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.MenuText;
            label2.Location = new Point(453, 30);
            label2.Name = "label2";
            label2.Size = new Size(294, 33);
            label2.TabIndex = 18;
            label2.Text = "Todo List Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 815);
            Controls.Add(label2);
            Controls.Add(btnFinished);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAddTask);
            Controls.Add(lstTasks);
            Controls.Add(label1);
            Controls.Add(txtTask);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private Label label1;
        private ListBox lstTasks;
        private Button btnAddTask;
        private Button btnClear;
        private Button btnDelete;
        private Button btnFinished;
        private Label label2;
        private ToolTip toolTip1;
    }
}
