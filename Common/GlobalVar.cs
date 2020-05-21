using System;
using System.Collections.Generic;

namespace PaletteStudio.Common
{
    public static class GlobalVar
    {
        public static string CurrentLanguage = "";
        public static Dictionary<string, Tuple<string, int, List<Tuple<int, int>>>> NewTemplates = new Dictionary<string, Tuple<string, int, List<Tuple<int, int>>>>();
    }
}
