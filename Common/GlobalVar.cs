using PaletteStudio.FileSystem;
using PaletteStudio.GUI.Dialogs;
using System;
using System.Collections.Generic;

namespace PaletteStudio.Common
{
    public static class GlobalVar
    {
        public static Dictionary<string, Tuple<string, int, List<Tuple<int, int>>>> NewTemplates = new Dictionary<string, Tuple<string, int, List<Tuple<int, int>>>>();
        public static bool IsFindOpening = false;
        public static bool exitMessageBox = true;
        public static Find FindWindow;
        public static INIFile INI;
        public static INIPair Language;
        public static INIPair NewLanguage;
    }
}
