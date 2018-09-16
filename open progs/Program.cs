using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace open_progs
{
    static class Program
    {
        static void Main()
        {
            Process.Start($@"C:\Users\{Environment.UserName}\source\repos");
            Application.Exit();
        }
    }
}
