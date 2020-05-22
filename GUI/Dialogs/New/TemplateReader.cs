using PaletteStudio.Common;
using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class New : Form
    {

        private void TreeViewInitialization()
        {
            string[] roots = GlobalVar.INI["RootNodes"]["Nodes"].Split(',');
            foreach(string temp in roots)
            {
                if (temp == "%DEFAULT")
                {
                    TreeNode treeNode = new TreeNode("Default");
                    List<int> data = new List<int>();
                    for (int i = 0; i < 256; i++) data.Add(Color.FromArgb(252, i, i, i).ToArgb());
                    treeNode.Tag = data;
                    lvTemplates.Nodes.Add(treeNode);
                }
                else LoadTemplates(temp, lvTemplates, null);
            }
        }

        private void LoadTemplates(string path, TreeView tv, TreeNode parent)
        {
            using(INIFile thisINI = new INIFile(path)){
                INIEntity node = thisINI.PopEnt("Node");
                bool isBody = node.PopPair("IsBody").ParseBool(true);
                string displayName = node.PopPair("DisplayName").Value;
                bool hasChild = node.PopPair("HasChild").ParseBool(false);
                string[] children = null;
                if (hasChild) children = node.PopPair("Children").ParseStringList();

                if (isBody)
                {
                    INIEntity body = thisINI.PopEnt("Body");
                    NewTemplateMode defaultMode = Enum.Parse(typeof(NewTemplateMode), body.PopPair("GlobalMode").Value);
                    List<int> data = new List<int>();
                    for (int i = 0; i < 256; i++)
                    {
                        INIPair pair = body.PopPair(i.ToString());
                        if (pair == INIPair.NullPair)
                        {
                            data.Add(Constant.Colors.PaletteBlack);
                            continue;
                        }
                        string[] tmp = pair.ParseStringList();
                        int defLen = Misc.GetTemplateLength(defaultMode);
                        if (tmp.Length > defLen)
                        {
                            NewTemplateMode curMode = (NewTemplateMode)Enum.Parse(typeof(NewTemplateMode), tmp[defLen]);
                            int curLen = Misc.GetTemplateLength(curMode);
                            if (tmp.Length != curLen + 1)
                            {
                                data.Add(Constant.Colors.PaletteBlack);
                                continue;
                            }
                            // else
                            data.Add(Misc.ReadColor(curMode, tmp));
                        }
                        else if (tmp.Length == defLen)
                        {
                            data.Add(Misc.ReadColor(defaultMode, tmp));
                        }
                        else
                        {
                            data.Add(Constant.Colors.PaletteBlack);
                        }
                        continue;
                    }
                    TreeNode tn = new TreeNode(displayName)
                    {
                        Tag = data
                    };
                    parent.Nodes.Add(tn);
                    return;
                }
                else
                {
                    if (!hasChild) return;
                    // else
                    TreeNode newParent = new TreeNode(displayName);
                    foreach (string child in children)
                    {
                        INIEntity thisEnt = thisINI.PopEnt(child);
                        LoadTemplates(thisEnt.PopPair("Path").Value, tv, newParent);
                    }
                    if (parent == null)
                    {
                        tv.Nodes.Add(newParent);
                        return;
                    }
                    else parent.Nodes.Add(newParent);
                }
            }
            
        }

    }
}