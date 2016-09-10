using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_Yoni_301812095_Idan_301911103.checkins
{
    class SpecialCheckin : ISpecialCheckin
    {
        public Checkin Checkin { get; set; }
        public int NumOfLikes { get; set; }

        public string Id
        {
            get
            {
                return Checkin.Id;
            }
        }

        public string Place
        {
            get
            {
                return Checkin.Place.Name;
            }
        }

        public ISpecialCheckin getSpecialCheckin(Checkin i_Checkin)
        {
            Checkin = i_Checkin;
            NumOfLikes = Checkin.LikedBy.Count;
            return this;
        }
    }
}
