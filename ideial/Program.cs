using System;
using System.Windows.Forms;

using DISgrupo1.Ideial.Teste;
using DISgrupo1.Ideial.View;

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
            Application.Run(new Login());
          //  Application.Run(new formTeste());
        }
    }
}
