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

            // $G$ THE-001 (-4) your grade on diagrams document - 96. please see comments inside the document. (40% of your grade).
            AppManager app = new AppManager();
            app.Start();
        }
    }
}
