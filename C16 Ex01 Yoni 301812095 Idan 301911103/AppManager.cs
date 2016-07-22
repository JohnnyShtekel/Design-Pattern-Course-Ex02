using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public class AppManager
    {
        public AppManager() {}
        public void Start()
        {   
            Application.Run(new FormLogin());
        }
    }
}
