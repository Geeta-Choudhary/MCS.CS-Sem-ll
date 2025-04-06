using System;
using System.Windows.Forms;

namespace College_Fest_Event_Handling
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CollegeFestForm());
        }
    }
}
