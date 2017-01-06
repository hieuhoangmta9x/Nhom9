using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VB2QLNS.Views;

namespace VB2QLNS
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
            Application.Run(new Views.frmMain());
        }
    }
}
