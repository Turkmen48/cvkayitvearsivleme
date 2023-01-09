using System;
using System.Windows.Forms;

namespace cvkayitvearsivleme
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Login login = new Login())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
