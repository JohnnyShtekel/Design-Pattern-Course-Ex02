using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_Yoni_301812095_Idan_301911103.checkins
{
    interface ISpecialCheckin
    {
        string Id { get; }
        string Place { get; }
        int NumOfLikes { get; set; }
        ISpecialCheckin getSpecialCheckin(Checkin i_Checkin);
    }
}
