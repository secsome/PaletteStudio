﻿using System;

namespace PaletteStudio.Utils.PCXReader
{
    public static class Util
    {
        public static UInt16 LittleEndian(UInt16 val)
        {
            if (BitConverter.IsLittleEndian) return val;
            return conv_endian(val);
        }
        public static UInt32 LittleEndian(UInt32 val)
        {
            if (BitConverter.IsLittleEndian) return val;
            return conv_endian(val);
        }

        public static UInt16 BigEndian(UInt16 val)
        {
            if (!BitConverter.IsLittleEndian) return val;
            return conv_endian(val);
        }
        public static UInt32 BigEndian(UInt32 val)
        {
            if (!BitConverter.IsLittleEndian) return val;
            return conv_endian(val);
        }

        private static UInt16 conv_endian(UInt16 val)
        {
            UInt16 temp;
            temp = (UInt16)(val << 8); temp &= 0xFF00; temp |= (UInt16)((val >> 8) & 0xFF);
            return temp;
        }
        private static UInt32 conv_endian(UInt32 val)
        {
            UInt32 temp = (val & 0x000000FF) << 24;
            temp |= (val & 0x0000FF00) << 8;
            temp |= (val & 0x00FF0000) >> 8;
            temp |= (val & 0xFF000000) >> 24;
            return (temp);
        }
    }
}