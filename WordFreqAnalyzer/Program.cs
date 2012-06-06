// Program.cs
/**
 * Author: Vladimir Sibirov
 * Version: 1.0.2 (mono-en)
 * Date: 2009-12-23 (2010-07-01)
 */
using System;
using System.Windows.Forms;

namespace TextAnalyzer
{
    /// <summary>
    /// Main entry point
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Главная точка входа
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainController controller = new MainController();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(controller));
        }
    }
}
