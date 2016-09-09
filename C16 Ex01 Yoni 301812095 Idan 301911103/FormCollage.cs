using C16_Ex01_Yoni_301812095_Idan_301911103.collage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public partial class FormCollage : Form
    {
        public FormCollage()
        {
            InitializeComponent();
        }

        private void buttonCreateCollage_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = Controls.OfType<RadioButton>()
                                      .FirstOrDefault(radio => radio.Checked);
          

            Bitmap choosenCollage =  collage.CollageFactory.Get((eCollageType)int.Parse(checkedButton.Tag.ToString()));
            pictureBoxCollage.Image = choosenCollage;



        }
    }
}
