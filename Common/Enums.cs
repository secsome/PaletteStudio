using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteStudio.Common
{
    public enum FileExtension
    {
        Undefined, CSV, TXT, YRM, MAP, INI, LANG, MIX, PAL, SHP, VXL, HVA, CSF,
        UnknownBinary = -1
    }
    public enum SortPrerferances
    {
        Red, Green, Blue,
        Hue, Saturation, Brightness,
        Gray, Argb, Comprehensive
    }
}
