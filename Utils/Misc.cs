using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using PaletteStudio.FileSystem;
using PaletteStudio.Common;
using System.Reflection;
using System.Drawing.Imaging;
using PaletteStudio.GUI;
using System.Threading;
using PaletteStudio.Utils.PCXReader;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using System.Windows.Forms;

namespace PaletteStudio.Utils
{
    public class Misc
    {
        public static void LoadLanguage()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            INIFile f = new INIFile(Constant.RunTime.INIFile);
            INIEntity ent = f[f["Language"][f["Settings"]["CurrentLanguage"]]];
            foreach (INIPair p in ent.DataList)
                dict[p.Name] = p.Value;
            Language.DICT = new Lang(dict);
        }
        public static void SetLanguage(Form f)
        {
            foreach (Control c in f.Controls) Language.SetControlLanguage(c);
            f.Text = Language.DICT[f.Text];
        }
        public static Bitmap DecodePCX(string path)
        {
            return PcxReader.Load(path);
        }
        public static byte GetRound(decimal num)
        {
            if (num < 0) return 0;
            if (num > 254) return 255;
            if (num - (byte)num > 0.5M) return (byte)(num + 1);
            else return (byte)num;
        }
        public static byte FindBestColor(Color color, PalFile pal)
        {
            byte bestIdx = 0;
            int minDistance = 195075; // 255* 255* 3
            for (int i = 0; i < 256; ++i)
            {
                Color palColor = Color.FromArgb(pal[(byte)i]);
                int deltaR = palColor.R - color.R;
                int deltaG = palColor.G - color.G;
                int deltaB = palColor.B - color.B;
                int delta = deltaR * deltaR + deltaG * deltaG + deltaB * deltaB;
                if (delta < minDistance)
                {
                    minDistance = delta;
                    bestIdx = (byte)i;
                }
            }
            return bestIdx;
        }
        public static void DeepCopy<T>(List<T> src, List<T> des)
        {
            des.Clear();
            foreach (T t in src) des.Add(t);
        }
        public static byte[] GetRawBytes(string _path)
        {
            return File.ReadAllBytes(_path);
        }
        public static string ColorToString(Color color)
        {
            return color.R + "," + color.G + "," + color.B;
        }
        public static string ColorToString(int argb)
        {
            return ColorToString(Color.FromArgb(argb));
        }
        public static double ColorToGray(Color color)
        {
            return (color.R * 19595 + color.G * 38469 + color.B * 7472) >> 16;
        }
        public static int ColorToArgb(int A,int R,int G,int B)
        {
            return Color.FromArgb(A, R, G, B).ToArgb();
        }
        public unsafe static void GetIndexedItem(Image img, PalFile pal)
        {
            List<int> myPalette = new List<int>();
            if (img.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                foreach (Color c in img.Palette.Entries)
                    myPalette.Add(c.ToArgb());
            }
            else
            {
                ImageFactory factory = new ImageFactory();
                factory.Load(img);
                ISupportedImageFormat format = new PngFormat { Quality = 100, IsIndexed = true};
                factory.Format(format);
                MemoryStream stream = new MemoryStream();
                factory.Save(stream);
                Bitmap src = new Bitmap(stream);
                stream.Dispose();
                Bitmap back = new Bitmap(src.Width, src.Height);
                Rectangle rect = new Rectangle(0, 0, src.Width, src.Height);
                BitmapData bmpData = src.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                byte* ptr = (byte*)bmpData.Scan0;
                for (int j = 0; j < src.Height; j++)
                {
                    for (int i = 0; i < src.Width; i++)
                    {
                        int argb = Color.FromArgb(252, ptr[2], ptr[1], ptr[0]).ToArgb();
                        if (!myPalette.Contains(argb)) myPalette.Add(argb);
                        ptr += 4;
                    }
                    ptr += bmpData.Stride - bmpData.Width * 4;
                }
                src.UnlockBits(bmpData);
                img = src;
            }
            while (myPalette.Count < 256) myPalette.Add(Constant.Colors.PaletteBlack);
            pal.Data = myPalette;
            return;
        }
    }
}
