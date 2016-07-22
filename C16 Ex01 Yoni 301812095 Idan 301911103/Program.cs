using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppManager app = new AppManager();
            app.Start();
        }
    }
}
