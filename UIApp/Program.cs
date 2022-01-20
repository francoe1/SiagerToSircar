using System;
using System.Windows.Forms;

namespace UIApp
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new DisplayProgress();
            Application.Run(new Main());
        }
    }
}
