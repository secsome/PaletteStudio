using PaletteStudio.Common;
using PaletteStudio.FileSystem;
using PaletteStudio.GUI.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PaletteStudio
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                InitializeGlobalVars();
                Utils.Misc.LoadLanguage();
                ReadNewTemplates();
            }
            catch
            {
                MessageBox.Show(Constant.RunTime.FatalOnInitializing, Constant.RunTime.ProgromTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static void InitializeGlobalVars()
        {
            GlobalVar.INI = new INIFile(Constant.RunTime.INIFile);
            GlobalVar.Language = GlobalVar.INI["Language"].GetPair(GlobalVar.INI["Settings"]["CurrentLanguage"]);
        }

        private static void ReadNewTemplates()
        {
            try
            {
                using (INIFile ini = new INIFile(Constant.RunTime.INIFile))
                {
                    foreach (INIPair pair in ini["Templates"])
                    {
                        try
                        {
                            string[] args = ((string)pair.Name).Split(',');
                            string name = args[0];
                            int count = int.Parse(args[1]);
                            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
                            for (int i = 1; i <= count; i++)
                                list.Add(new Tuple<int, int>(int.Parse(args[i * 2]), int.Parse(args[i * 2 + 1])));
                            GlobalVar.NewTemplates[pair.Name] = new Tuple<string, int, List<Tuple<int, int>>>(name, count, list);
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }
    }
}
