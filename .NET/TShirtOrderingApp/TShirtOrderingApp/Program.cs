
using System;
using System.Windows.Forms;

namespace TShirtOrderingApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());  // This line should point to MainMenuForm
        }
    }
}

