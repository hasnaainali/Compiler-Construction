using System;
using System.Windows.Forms;

namespace FirstTask // Make sure this matches other files
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
