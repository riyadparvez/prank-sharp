﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prank
{
    static class Program
    {
        //private System.Windows.Forms.NotifyIcon notifyIcon;

        public static PrankConfigurationSection Config { get; internal set; }

        public static void Initialize()
        {
            Config = ConfigurationManager.GetSection("prank") as PrankConfigurationSection;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrankForm());
        }
    }
}
