using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DiffIconPic.Lib
{
    class Constant
    {
        public static string GarminIconFolder = "";
        public static string GarminNouseIconFolder = "";
        public static string Nav2IconFolder = "";

        public static void setConstantGarminPathValue(string garminFolder)
        {
            if (Directory.Exists(garminFolder))
            {
                GarminIconFolder = garminFolder;
                GarminNouseIconFolder = garminFolder + @"\nouse";
            }
        }

        public static void setConstantNav2PathValue(string nav2Folder)
        {
            if (Directory.Exists(nav2Folder))
            {
                Nav2IconFolder = nav2Folder;
            }
        }
    }
}
