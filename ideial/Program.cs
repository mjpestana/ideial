using System;
using System.Windows.Forms;

using ideial.View;

namespace ideial
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Login
            Login_frm loginForm = new Login_frm();
            Application.Run(loginForm);
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new Main_frm());
            }

        }
    }
}
