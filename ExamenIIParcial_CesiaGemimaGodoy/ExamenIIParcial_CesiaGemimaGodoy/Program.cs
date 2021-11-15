using ExamenIIParcial_CesiaGemimaGodoy.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamenIIParcial_CesiaGemimaGodoy
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
            Application.Run(new LoginWiew());
        }
    }
}
