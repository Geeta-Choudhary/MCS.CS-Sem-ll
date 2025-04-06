using System;
using System.Windows.Forms;

namespace College_Fest_Event_Handling
{
    public partial class CollegeFestForm : Form
    {
        public CollegeFestForm()
        {
            InitializeComponent();
        }

        private void btnOrganizeFest_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVisitors.Text, out int visitors) || visitors < 0)
            {
                MessageBox.Show("Please enter a valid number of visitors.");
                return;
            }

            College college = new College();
            Caterer caterer = new Caterer();
            Decorator decorator = new Decorator();

            college.CollegeFest += caterer.OnCollegeFest;
            college.CollegeFest += decorator.OnCollegeFest;

            college.OrganizeFest(visitors);

            txtOutput.Text = $"{caterer.CateringBill}\r\n{decorator.DecorationBill}";
        }
    }
}
