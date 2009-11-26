using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MP3TagRenamer
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
            Application.SetCompatibleTextRenderingDefault( false );
            RestartFormIfLangageChaned();
        }

        private static void RestartFormIfLangageChaned()
        {
            try
            {
                Application.Run(new MainForm());
            }
            catch (ApplicationException)
            {
                RestartFormIfLangageChaned();
            }
        }
    }
}