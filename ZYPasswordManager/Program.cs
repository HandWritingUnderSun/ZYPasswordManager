﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYPM.UI;

namespace ZYPasswordManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Frm_Main frm = new Frm_Main();
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }
    }
}
