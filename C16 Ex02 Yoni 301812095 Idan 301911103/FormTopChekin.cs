using C16_Ex01_Yoni_301812095_Idan_301911103.checkins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C16_Ex01_Yoni_301812095_Idan_301911103
{
    public partial class FormTopCheckin : Form
    {
        private SpecialCheckin specificCheckIn;

        public FormTopCheckin()
        {
            
            InitializeComponent();
            
        }

        private void loadCheckins()
        {
            ListViewItem tempItem;
            this.Invoke(new Action(() =>
            {

                List<ISpecialCheckin> specialCheckin = LoggedInUser.Instance().GetAllCheckins();
                List<ISpecialCheckin> SoretedspecialCheckin = specialCheckin.OrderByDescending(s => s.NumOfLikes).ToList();
                foreach (ISpecialCheckin sp in SoretedspecialCheckin)
                {
                    specificCheckIn = sp as SpecialCheckin;
                    tempItem = new ListViewItem(sp.Id);
                    tempItem.SubItems.Add(sp.Place);
                    tempItem.SubItems.Add(sp.NumOfLikes.ToString());
                    listViewCheckins.Items.Add(tempItem);
                }
            }));
            

            
        }

        private void FormTopCheckin_Shown(object sender, EventArgs e)
        {
            new Thread(loadCheckins).Start();
        }
    }
}
