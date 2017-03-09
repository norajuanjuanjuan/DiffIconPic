using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace DiffIconPic.Lib
{
    class PictureHelper
    {
        public static Bitmap GetBitmap(string path)
        {
            FileStream fs = new FileStream(path,FileMode.Open);
            Bitmap bmp = new Bitmap(fs);
            fs.Close();

            return bmp;
        }
        public class rgbColor
        {
            public int R;
            public int G;
            public int B;
            public rgbColor()
            { }
            public rgbColor(int r, int g, int b)
            {
                R = r;
                G = g;
                B = b;
            }
        }

      static  bool CompareRGB(rgbColor a, rgbColor b)
        {
            if ((a.R == b.R) && (a.G == b.G) && (a.B == b.B))
                return true;
            else return false;
        }

      static  float GetSimilarityofListrgb(List<rgbColor> list_a, List<rgbColor> list_b)
        {
            float result = 0f;
            int flag = 0;
            int min_count = list_a.Count;
            if (list_a.Count != list_b.Count)
            {
                if (list_a.Count > list_b.Count) min_count = list_b.Count;
            }

            for (int i = 0; i < min_count; i++)
            {
                if (CompareRGB(list_a[i], list_b[i]))
                {
                    flag++;
                }
            }

            double a = Convert.ToDouble(flag);
            result = (float)(a / list_a.Count);
            return result * 100;

        }

       static List<rgbColor> GetRGBfromPixels_2(string filePath)
        {
            List<rgbColor> list_rgb = new List<rgbColor>();
            Bitmap bmp = GetBitmap(filePath);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                byte* ptr = (byte*)(bmpData.Scan0);
                for (int i = 0; i < bmpData.Height; i++)
                {
                    for (int j = 0; j < bmpData.Width; j++)
                    {
                        rgbColor rgb = new rgbColor(ptr[2], ptr[1], ptr[0]);
                        list_rgb.Add(rgb);
                        ptr += 3;
                    }
                    ptr += bmpData.Stride - bmpData.Width * 3;
                }
            }
            return list_rgb;
        }

        public static Dictionary<string,string> GetAllPicPath(string folder)
        {
            Dictionary<string, string> dic_fileName_path = new Dictionary<string, string>();
            if (Directory.GetFiles(folder).Length > 0)
            {
                foreach (string var in Directory.GetFiles(folder))
                {
                    if (var.Contains("_day_2.png"))//只拿出32*32的
                        if (!dic_fileName_path.ContainsKey(var)) dic_fileName_path.Add(Path.GetFileName(var), var);
                }
            }
            return dic_fileName_path;
        }

        public static void ResizeIcon32(string sourcePath,int size,string targetFolder)
        {
            Bitmap bmp = GetBitmap(sourcePath);
            string bmp_fileName = Path.GetFileNameWithoutExtension(sourcePath);
            string brandId = bmp_fileName.Split('_')[0];
            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);
            Bitmap result = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(result))
                g.DrawImage(bmp, 0, 0, size, size);
            string nmbr ="1";
            if (size == 48) nmbr = "3";
            if (size == 24) nmbr = "1";
            result.Save(targetFolder+@"\"+brandId+"_day_"+nmbr+".png");
        }

        public static List<string> GetNewIconPath(Dictionary<string,string> dic_garmin,Dictionary<string,string> dic_Nav2)
        {
            List<string> list_new_icon = new List<string>();
           foreach(KeyValuePair<string ,string> kvp in dic_Nav2)
            {
                if (!dic_garmin.Keys.Contains(kvp.Key)) 
                    if(!GetNouseBrandIcon().Contains(kvp.Key))
                    list_new_icon.Add(kvp.Value);
            }
            return list_new_icon;
        }

        public static List<string> GetNouseBrandIcon()
        {
            List<string> list_nouse_fileName=new List<string>();
            string nouseFolder = Constant.GarminNouseIconFolder;
            if (Directory.Exists(nouseFolder))
            {
                Dictionary<string, string> dic_nouse_FileName_Path = GetAllPicPath(nouseFolder);
                foreach (KeyValuePair<string, string> kvp in dic_nouse_FileName_Path)
                {
                    if (!list_nouse_fileName.Contains(kvp.Key))
                        list_nouse_fileName.Add(kvp.Key);
                }
            }
            return list_nouse_fileName;
        }

        public static List<string> GetDiffIconPath(Dictionary<string, string> dic_garmin, Dictionary<string, string> dic_Nav2)
        {
            List<string> list_diff_icon = new List<string>();
            List<string> list_new_icon_path = GetNewIconPath(dic_garmin, dic_Nav2);
            foreach (KeyValuePair<string, string> kvp in dic_garmin)
            {
                if (!list_new_icon_path.Contains(kvp.Value))
                {
                    foreach (KeyValuePair<string, string> kvp2 in dic_Nav2)
                    {
                        if (kvp.Key == kvp2.Key)
                        {
                            List<rgbColor> list_A = GetRGBfromPixels_2(kvp.Value);
                            List<rgbColor> list_B = GetRGBfromPixels_2(kvp2.Value);
                            string result = GetSimilarityofListrgb(list_A, list_B).ToString();
                            if (result!="100")
                            {
                                //backup 旧数据
                                list_diff_icon.Add(kvp2.Value);
                            }
                        }
                    }
                }
            }
            return list_diff_icon;
        }

        public static byte[] GetByteImage(Bitmap bmp)
        {
            byte[] bt = null;
            if (!bmp.Equals(null))
            {
                using (MemoryStream mostream = new MemoryStream())
                {
                    bmp.Save(mostream, System.Drawing.Imaging.ImageFormat.Png);//将图像以指定的格式存入缓存内存流
                    bt = new byte[mostream.Length];
                    mostream.Position = 0;//设置留的初始位置
                    mostream.Read(bt, 0, Convert.ToInt32(bt.Length));
                }
            }
            return bt;
        }
    }
}
