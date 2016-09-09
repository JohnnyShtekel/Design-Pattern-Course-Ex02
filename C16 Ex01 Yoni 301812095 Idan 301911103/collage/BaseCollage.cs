using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace C16_Ex01_Yoni_301812095_Idan_301911103.collage
{
    public abstract class BaseCollage
    {
        protected List<string> m_CollagePictureUrls;

        public abstract List<string> getFriendsPicture();


        public Bitmap GetCollage(List<string> i_CollagePictureUrls)
        {
            Bitmap collage = null;
            List<string> filespath;
            filespath  = dowloadUrlsToFiles(i_CollagePictureUrls);
            collage = CombineBitmap(filespath);
            return collage;
        }

     

        private List<string> dowloadUrlsToFiles(List<string> i_CollagePictureUrls)
        {
            List<string> filesPath = new List<string>(); 
            int index = 0;
            foreach (string url in i_CollagePictureUrls)
            {
                using (var client = new WebClient())
                {
                    string fileName = index.ToString() + ".jpg";
                    client.DownloadFile(url, fileName);
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                    index++;
                    filesPath.Add(filePath);
                }
            }

            return filesPath;


        }

        private  Bitmap CombineBitmap(List<string> i_CollagePicturePaths)
        {

            List<Bitmap> images = new List<Bitmap>();
            Bitmap finalImage = null;

            try
            {
                int width = 0;
                int height = 0;

                foreach (string image in i_CollagePicturePaths)
                {
                    Bitmap bitmap = new System.Drawing.Bitmap(image);

                    
                    width += bitmap.Width;
                    height = bitmap.Height > height ? bitmap.Height : height;

                    images.Add(bitmap);
                }
 
                finalImage = new Bitmap(width, height);

                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    g.Clear(System.Drawing.Color.Black);

                    int offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                          new System.Drawing.Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null)
                    finalImage.Dispose();
                throw;
            }
            finally
            {
                foreach (Bitmap image in images)
                {
                    image.Dispose();
                }
            }
        }
    }
}
