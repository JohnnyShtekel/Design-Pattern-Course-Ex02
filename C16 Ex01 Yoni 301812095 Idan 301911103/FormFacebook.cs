using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public partial class FormFacebook : Form
    {
        public FormFacebook()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        User m_LoggedInUser;
    }
}
