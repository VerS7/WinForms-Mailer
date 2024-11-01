using System;
using System.Windows.Forms;


namespace WFMailer
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
