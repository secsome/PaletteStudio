using PaletteStudio.FileSystem;
using PaletteStudio.Common;
using PaletteStudio.Utils.PCXReader;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Imaging.Quantizers;
using System.Windows.Forms;
using System.Security.Policy;
using System;

namespace PaletteStudio.Utils
{
    public class Misc
    {
        public static int ReadColor(NewTemplateMode mode,string[] list)
        {
            switch (mode)
            {
                case NewTemplateMode.ARGB:
                    return int.Parse(list[0]);
                case NewTemplateMode.RGB:
                    return Color.FromArgb(252, int.Parse(list[0]), int.Parse(list[1]), int.Parse(list[2])).ToArgb();
                case NewTemplateMode.HTML:
                    Color c = ColorTranslator.FromHtml(list[0]);
                    return Color.FromArgb(252, c.R, c.G, c.B).ToArgb();
                default:
                    return int.MaxValue;
            }
        }
        public static int GetTemplateLength(NewTemplateMode mode)
        {
            switch (mode)
            {
                case NewTemplateMode.ARGB:
                    return 1;
                case NewTemplateMode.HTML:
                    return 1;
                case NewTemplateMode.RGB:
                    return 3;
                default:
                    return int.MaxValue;
            }
        }
        public static string ToHtml(Color color)
        {
            return ColorTranslator.ToHtml(color.A == 252 ? color : Color.FromArgb(252, color.R, color.G, color.B));
        }
        public static string ToHtml(int argb)
        {
            Color tmp = Color.FromArgb(argb);
            return ToHtml(Color.FromArgb(tmp.R, tmp.G, tmp.B));
        }
        public static Color FromHtml(string html)
        {
            Color tmp = ColorTranslator.FromHtml(html);
            return Color.FromArgb(252, tmp.R, tmp.G, tmp.B);
        }
        public static void LoadLanguage()
        {
            LoadLanguage(GlobalVar.Language.Name);
        }
        public static void LoadLanguage(string ID)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            INIEntity ent = GlobalVar.INI[ID];
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
        public unsafe static void GetIndexedItem(Image img, PalFile pal, int maxNum, int mode = 2)
        {
            List<int> myPalette = new List<int>();
            if (img.PixelFormat == PixelFormat.Format8bppIndexed)
            {
                foreach (Color c in img.Palette.Entries)
                    myPalette.Add(c.ToArgb());
            }
            else
            {
                switch (mode)
                {
                    case 0: // Even
                        HashSet<int> _set = new HashSet<int>();
                        Bitmap pic = new Bitmap(img);
                        BitmapData picData = pic.LockBits(
                                new Rectangle(0, 0, pic.Width, pic.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format32bppArgb
                                );
                        byte* __ptr = (byte*)picData.Scan0;
                        for (int j = 0; j < pic.Height; ++j)
                        {
                            for (int i = 0; i < pic.Width; ++i)
                            {
                                int argb = Color.FromArgb(252, __ptr[2], __ptr[1], __ptr[0]).ToArgb();
                                _set.Add(argb);
                                __ptr += 4;
                            }
                            __ptr += picData.Stride - picData.Width * 4;
                        }
                        int STEP = 1;
                        while (_set.Count > 255) 
                        {
                            var setarr = _set.ToArray();
                            foreach(int argb in setarr)
                            {
                                Color clr = Color.FromArgb(argb);
                                int nR = clr.R / (int)Math.Pow(8, STEP) * (int)Math.Pow(8, STEP);
                                int nG = clr.G / (int)Math.Pow(8, STEP) * (int)Math.Pow(8, STEP);
                                int nB = clr.B / (int)Math.Pow(4, STEP) * (int)Math.Pow(4, STEP);
                                clr = Color.FromArgb(252, nR, nG, nB);
                            }
                            _set.Clear();
                            foreach (int argb in setarr)
                                _set.Add(argb);
                            ++STEP;
                        }
                        myPalette = _set.ToList();
                        break;
                    case 1: // Frequency
                        {
                            Dictionary<int,int> filt = new Dictionary<int, int>();
                            Bitmap tmp = new Bitmap(img);
                            BitmapData tmpData = tmp.LockBits(
                                new Rectangle(0, 0, tmp.Width, tmp.Height),
                                ImageLockMode.ReadWrite,
                                PixelFormat.Format32bppArgb
                                );
                            byte* _ptr = (byte*)tmpData.Scan0;
                            for (int j = 0; j < tmp.Height; ++j) 
                            {
                                for (int i = 0; i < tmp.Width; ++i) 
                                {
                                    int argb = Color.FromArgb(252, _ptr[2], _ptr[1], _ptr[0]).ToArgb();
                                    if (filt.ContainsKey(argb)) ++filt[argb];
                                    else filt[argb] = 1;
                                    _ptr += 4;
                                }
                                _ptr += tmpData.Stride - tmpData.Width * 4;
                            }
                            var retarr = filt.ToArray();
                            retarr.OrderByDescending(a => a.Value);
                            int cnt = Math.Min(255, retarr.Count());
                            for (int i = 0; i <= cnt; ++i)
                                myPalette.Add(retarr[i].Key);
                        }
                        break;
                    case 2: // Mid Cut
                    default:
                        HashSet<int> set = new HashSet<int>();
                        ImageFactory factory = new ImageFactory();
                        factory.Load(img);
                        ISupportedImageFormat format = new PngFormat { Quality = 100, IsIndexed = true, Quantizer = new OctreeQuantizer(maxNum, 8) };
                        factory.Format(format);
                        MemoryStream stream = new MemoryStream();
                        factory.Save(stream);
                        img = Image.FromStream(stream);
                        stream.Dispose();
                        Bitmap src = new Bitmap(img);
                        Rectangle rect = new Rectangle(0, 0, src.Width, src.Height);
                        BitmapData bmpData = src.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
                        byte* ptr = (byte*)bmpData.Scan0;
                        for (int j = 0; j < src.Height; j++)
                        {
                            for (int i = 0; i < src.Width; i++)
                            {
                                int argb = Color.FromArgb(252, ptr[2], ptr[1], ptr[0]).ToArgb();
                                set.Add(argb);
                                ptr += 4;
                            }
                            ptr += bmpData.Stride - bmpData.Width * 4;
                        }
                        src.UnlockBits(bmpData);
                        img = src;
                        myPalette = set.ToList();
                        break;
                }
            }
            while (myPalette.Count < 256) myPalette.Add(Constant.Colors.PaletteBlack);
            pal.Data = myPalette;
        }
        public unsafe static void GifToIndex(Image img, PalFile pal)
        {
            PropertyItem[] props = img.PropertyItems;
            HashSet<int> set = new HashSet<int>();
            foreach(PropertyItem x in props)
                if(x.Id== 0x5102)
                    for (int i = 0; i < x.Len; i += 3)
                        set.Add(Color.FromArgb(252, x.Value[i], x.Value[i + 1], x.Value[i + 2]).ToArgb());

            if (set.Count > 256)
            {
                Bitmap bmp = new Bitmap(1, set.Count);
                GetIndexedItem(bmp, pal, 255);
            }
            else
            {
                pal.Data = set.ToList();
                while (pal.Data.Count < 256) pal.Data.Add(Constant.Colors.PaletteBlack);
            }
            
            //HashSet<int> set = new HashSet<int>();
            //FrameDimension fd = new FrameDimension(img.FrameDimensionsList[0]);
            //for (int k = 0; k < framecount; k++)
            //{
            //    img.SelectActiveFrame(fd, k);
            //    Bitmap src = new Bitmap(img);
            //    Rectangle rect = new Rectangle(0, 0, src.Width, src.Height);
            //    BitmapData bmpData = src.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            //    byte* ptr = (byte*)bmpData.Scan0;
            //    for (int j = 0; j < src.Height; j++)
            //    {
            //        for (int i = 0; i < src.Width; i++)
            //        {
            //            if (ptr[3] != 0) set.Add(Color.FromArgb(ptr[3], ptr[2], ptr[1], ptr[0]).ToArgb());
            //            ptr += 4;
            //        }
            //        ptr += bmpData.Stride - bmpData.Width * 4;
            //    }
            //    src.UnlockBits(bmpData);
            //    src.Dispose();
            //}
            //pal.Data = set.ToList();
        }
    }
}
