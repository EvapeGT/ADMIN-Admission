﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices; // Include this for DllImport
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAdmission
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Check if the OS version is greater than or equal to 6 and set DPI awareness
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Import the SetProcessDPIAware function from user32.dll
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
