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
using DmitryBrant.ImageFormats;
using PaletteStudio.GUI;
using System.Threading;

namespace PaletteStudio.Utils
{
    public class Misc
    {
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
        public static T MemCpy<T>(T src)
        {
            T dest = Activator.CreateInstance<T>();
            Type tIn = src.GetType();
            foreach (var itemDest in dest.GetType().GetProperties())
            {
                var itemSrc = tIn.GetProperty(itemDest.Name);
                if (itemSrc != null && itemDest.CanWrite)
                {
                    itemDest.SetValue(dest, itemSrc.GetValue(src));
                }
            }
            return dest;
        }
        public static Color ToColor(string[] src)
        {
            int r = 0xFF, g = 0xFF, b = 0xFF;
            if (src.Length != 3) return Color.FromArgb(0x00000000);
            try
            {
                r = int.Parse(src[0]);
                g = int.Parse(src[1]);
                b = int.Parse(src[2]);
            }
            catch
            {
                return Color.FromArgb(0x00000000);
            }
            return Color.FromArgb(r, g, b);
        }
        public static Color ToColor(uint remapcolor)
        {
            int r = (int)(remapcolor & 0xFF);
            int g = (int)(remapcolor & 0xFF00) >> 8;
            int b = (int)(remapcolor & 0xFF0000) >> 16;
            return Color.FromArgb(r, g, b);
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
        public static Image GetImage(string _path)
        {
            return Image.FromFile(_path);
        }
        public static void GetPal(PalFile pal)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "PNG2SHP.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = false;
            p.StartInfo.RedirectStandardOutput = false;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.Arguments = @"PaletteStudio.tmp PaletteStudio.tmpA PaletteStudio.tmpB";
            p.Start();
            p.WaitForExit();
            p.Close();
            DeepCopy(new PalFile("PaletteStudio.tmpB").Data, pal.Data);
            return;
        }
    }
}
