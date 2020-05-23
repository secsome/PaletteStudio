using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using PaletteStudio.Utils;
using System.Drawing;

namespace PaletteStudio.FileSystem
{
    public class PalFile : BaseFile
    {
        private List<int> data = new List<int>();


        #region Ctor - PalFile
        public PalFile() { for (int i = 0; i < 256; i++) data.Add(0); }
        public PalFile(Stream baseStream, string _fullName) : base(baseStream, _fullName)
        {
            Load();
        }
        public PalFile(byte[] _rawData, string _fullName) : base(_rawData, _fullName)
        {
            Load();
        }
        public PalFile(string _path) : base(Misc.GetRawBytes(_path), _path.Split('\\').LastOrDefault())
        {
            Load();
        }
        #endregion


        #region Private Methods - PalFile
        private void Load()
        {
            if (FileLength != 768) throw new Exception("NOT A RA2/TS PALETTE");
            for (int i = 0; i < 256; i++)
            {
                /*
                int tmp = (ReadByte() << 18) + (ReadByte() << 10) + (ReadByte() << 2) + (0xFF << 26);
                data.Add(tmp);
                */
                int tmp = Color.FromArgb(252, ReadByte() * 4, ReadByte() * 4, ReadByte() * 4).ToArgb();
                data.Add(tmp);
            }
        }
        #endregion


        #region Public Methods - PalFile
        public void Export(StreamWriter sw, string name)
        {
            // Write Heads
            sw.Write("[Node]\nIsBody=true\nDisplayName=" + name + "\nHasChild=false\n\n[Body]\nGlobalMode=ARGB\n");
            for (int i = 0; i < 256; i++) sw.WriteLine(i.ToString() + "=" + data[i]);
            sw.Close();
        }

        public void Export(string _path)
        {
            Export(new StreamWriter(_path), _path.Split('\\').Last().Split('.').First());
        }

        public void Save(BinaryWriter bw)
        {
            for(int i = 0; i < 256; i++)
            {
                /*
                bw.Write((byte)(data[i] >> 18 & 0xFF));
                bw.Write((byte)(data[i] >> 10 & 0xFF));
                bw.Write((byte)(data[i] >> 2 & 0xFF));
                */
                Color c = Color.FromArgb(data[i]);
                bw.Write((byte)(c.R / 4));
                bw.Write((byte)(c.G / 4));
                bw.Write((byte)(c.B / 4));
            }
            bw.Dispose();
        }

        public void Save(string _path)
        {
            StreamWriter sw = new StreamWriter(_path);
            Save(new BinaryWriter(sw.BaseStream));
        }

        public void Save()
        {
            Save(FilePath);
        }

        public void SaveJASC(string _path)
        {
            File.Delete(_path);
            using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("JASC-PAL");
                    sw.WriteLine(data.Count.ToString("X4"));
                    sw.WriteLine(data.Count.ToString());

                    for (int i = 0; i < data.Count; i++)
                    {
                        Color now = Color.FromArgb(data[i]);
                        sw.WriteLine(now.R + " " + now.G + " " + now.B);
                    }
                        
                }
            }
        }
        #endregion


        #region Public Calls - PalFile
        public int this[byte index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public int TransparentColor { get { return data[0]; } }
        public List<int> Data { get { return data; } set { data = value; } }
        #endregion
    }
}
