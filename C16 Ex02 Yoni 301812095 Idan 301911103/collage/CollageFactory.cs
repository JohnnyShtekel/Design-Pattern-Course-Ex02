using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace C16_Ex01_Yoni_301812095_Idan_301911103.collage
{
    public static class CollageFactory
    {
        public static Bitmap Get(eCollageType i_ChoosenCollage)
        {
            Bitmap collage = null;
            BaseCollage collageMaker;
            if (i_ChoosenCollage == eCollageType.OldCollage)
            {
                collageMaker = new OldPhotosCollage();
                collage = collageMaker.GetCollage(collageMaker.getFriendsPicture());
            }
            else if (i_ChoosenCollage == eCollageType.NewCollage)
            {
                collageMaker = new NewPhotosCollage();
                collage = collageMaker.GetCollage(collageMaker.getFriendsPicture());

            }

            return collage;
        }
    }
}
