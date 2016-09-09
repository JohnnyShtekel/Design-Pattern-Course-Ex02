using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C16_Ex01_Yoni_301812095_Idan_301911103.collage
{
    class NewPhotosCollage : BaseCollage
    {
        public override List<string> getFriendsPicture()
        {
            return LoggedInUser.Instance().GetNewPhotosImTagIn();
        }
    }
}
