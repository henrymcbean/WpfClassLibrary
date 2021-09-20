using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace WpfClassLibrary
{
    public class WgmatePrintUtilClass
    {
        public static WGmateConfig WGmateConf;
        static WgmatePrintUtilClass()
        {
            WGmateConf = (WGmateConfig)Application.Current.MainWindow.GetType().GetProperty("TableWGmateConfig").GetValue(Application.Current.MainWindow, null);
        }
        public static string GetImageFileName(short Scratch,  short Option, string Style)
        {
            string sFilePath = "";
            string sFielName = "";
            string GmDataDir = "";
            bool bFound = false;

            // Data Folder
            GmDataDir = Environment.CurrentDirectory;

            switch (Scratch)
            { 
                case 0:
                    switch (Option)
                    {
                        case 0: // Images
                            sFilePath = WGmateConf.ImagePath;
                            break;
                        case 1: // Sketches
                            sFilePath = WGmateConf.Sketch;
                            break;
                        case 2: // Material Colour
                            sFilePath = WGmateConf.Material;
                            break;
                        case 3: // Wash List
                            sFilePath = WGmateConf.CareInstruction;
                            break;
                        case 4: // Scanned Images
                            sFilePath = WGmateConf.Scanned;
                            break;
                    }
                    break;
                case 1:
                    break;
                case 2:
                    sFilePath = string.Format("IMAGES{0}\\IMAGES", Option);
                    break;
            } // end switch

            for (int i = 0; i < 3;i++)
            {
                switch (i)
                {
                    case 0: // .bmp
                        sFielName = sFilePath + "\\" + Style + ".bmp";
                        break;
                    case 1: // .jpg
                        sFielName = sFilePath + "\\" + Style + ".jpg";
                        break;
                    case 2: // .gif
                        sFielName = sFilePath + "\\" + Style + ".gif";
                        break;
                }

                if (File.Exists(sFielName))
                {
                    bFound = true;
                    break;
                }
            }

            return bFound ? sFielName : "";
        }
        public static byte[] BufferFromImage(string ImageLocation)
        {
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(ImageLocation);

            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            imageData = br.ReadBytes((int)imageFileLength);
            return imageData;
        }
    }
}
