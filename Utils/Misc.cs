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

namespace PaletteStudio.Utils
{
    public class Misc
    {
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
        /// <summary>
        /// Return black(0x00000000) if something happened
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
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
        public static unsafe PalFile GetIndexPalette(Bitmap bmp)
        {
            PalFile ret = new PalFile();
            long[] counter = new long[4096];
            List<long> sorter;

            BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            byte* ptr = (byte*)(bitmapData.Scan0);
            for (int j = 0; j < bmp.Height; j++)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    int idx = ((ptr[0] & 0xF0) << 4) + (ptr[1] & 0xF0) + ((ptr[2] & 0xF0) >> 4);
                    ++counter[idx];
                    ptr += 4;
                }
                ptr += bitmapData.Stride - bitmapData.Width * 4;
            }
            bmp.UnlockBits(bitmapData);

            sorter = counter.ToList();
            sorter.Sort();

            for (int i = 0; i < 256; i++)
            {
                int Red = (byte)(sorter[i] & 0x00F << 4);
                int Green = (byte)(sorter[i] & 0x0F0);
                int Blue = (byte)(sorter[i] & 0xF00 >> 4);
                ret[(byte)i] = Color.FromArgb(Red, Green, Blue).ToArgb();
            }

            return ret;
        }
    }
}
