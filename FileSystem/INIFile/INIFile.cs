﻿using System.Collections.Generic;
using System.Linq;
using System.IO;
using PaletteStudio.Common;
using System;

namespace PaletteStudio.FileSystem
{
    public class INIFile : BaseFile
    {
        private Dictionary<string, INIEntity> inidata = new Dictionary<string, INIEntity>();
        private INIFileType initype;


        #region Ctor - INIFile
        public INIFile(string path, INIFileType itype = INIFileType.DefaultINI) : base(path, FileMode.Open, FileAccess.Read, false)
        {
            initype = itype;
            Load();
        }
        public INIFile(byte[] _data, string _filename, INIFileType _type = INIFileType.DefaultINI) : base(_data, _filename)
        {
            initype = _type;
            Load();
        }
        public INIFile()
        {
            initype = INIFileType.UnknownINI;
        }
        #endregion


        #region Private Methods - INIFile
        private void Load()
        {
            bool init = true;
            string preCommentBuffer = "";
            INIEntity ent = new INIEntity();
            string rootname = "";
            string rootcom = "";
            while (CanRead())
            {
                string line = Readline();
                string combuf = "";
                if (line.Contains(";"))
                {
                    string[] ls = line.Split(new char[] { ';' }, 2);
                    if (ls[0] == "")
                    {
                        preCommentBuffer += ";" + ls[1] + "\n";
                        continue;
                    }
                    else combuf = ls[1];
                    line = ls[0];
                }
                line = line.Replace("\t", string.Empty).Replace("\r\n", string.Empty).Replace("\r", string.Empty);
                line = line.Trim();
                if (line == "") continue;
                if (line.StartsWith("["))
                {
                    if (init)
                    {
                        init = false;
                        rootname = line.Replace("[", string.Empty).Replace("]", string.Empty);
                        ent = new INIEntity(rootname, preCommentBuffer, combuf);
                        preCommentBuffer = "";
                        continue;
                    }
                    AddEnt(ent);
                    rootname = line.Replace("[", string.Empty).Replace("]", string.Empty);
                    ent = new INIEntity(rootname, preCommentBuffer, combuf);
                    rootcom = combuf;
                }
                else if (line.StartsWith("*")) continue;
                else
                {
                    INIPair p;
                    string[] tmp = line.Split(new char[] { '=' }, 2);
                    if (tmp.Length == 1) p = new INIPair(tmp[0].Trim(), "", combuf, preCommentBuffer);
                    else p = new INIPair(tmp[0].Trim(), tmp[1].Trim(), combuf, preCommentBuffer);
                    ent.AddPair(p);
                    preCommentBuffer = "";
                }
            }
            AddEnt(ent);
        }
        #endregion


        #region Public Methods - INIFile
        /// <summary>
        /// Merge two IniFile, Entity with same name will be merged, IniPair with same key will be overwrite by new one
        /// </summary>
        /// <param name="newEnt">New Ent</param>
        public void Override(IEnumerable<INIEntity> src)
        {
            foreach (INIEntity newent in src)
            {
                if (HasIniEnt(newent))
                {
                    IniDict[newent.Name].JoinWith(newent);
                }
                else
                {
                    AddEnt(newent);
                }
            }
        }
        /// <summary>
        /// Save current IniFile structure into a file
        /// </summary>
        /// <param name="ignoreComment"></param>
        public void SaveIni(bool ignoreComment = false)
        {
            //if (File.Exists(FilePath)) File.Delete(FilePath);
            FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
            MemoryStream msbuffer = new MemoryStream();
            StreamWriter sw = new StreamWriter(msbuffer);
            foreach (INIEntity ent in IniData)
            {
                if (!ignoreComment) sw.Write(ent.PreComment);
                sw.Write("[" + ent.Name + "]");
                if (!ignoreComment && ent.HasComment) sw.Write(";" + ent.Comment);
                sw.Write("\n");
                foreach (INIPair p in ent.DataList)
                {
                    if (!ignoreComment) sw.Write(p.PreComment);
                    sw.Write(p.Name + "=" + p.Value.ToString());
                    if (!ignoreComment && p.HasComment) sw.Write(";" + p.Comment);
                    sw.Write("\n");
                }
                sw.Write("\n");
                sw.Flush();
            }
            msbuffer.WriteTo(fs);
            sw.Dispose();
            fs.Dispose();
            msbuffer.Dispose();
            Dispose();
        }
        /// <summary>
        /// Add an IniEnt, if there is an IniEnt with same name, it will do nothing
        /// </summary>
        /// <param name="ent"></param>
        public void AddEnt(INIEntity ent)
        {
            if (string.IsNullOrEmpty(ent.Name)) return;
            if (!inidata.Keys.Contains(ent.Name)) inidata[ent.Name] = ent;
        }
        /// <summary>
        /// Remove an IniEnt with a specified name, will do nothing if not found
        /// </summary>
        /// <param name="ent"></param>
        public void RemoveEnt(INIEntity ent)
        {
            if (inidata.Keys.Contains(ent.Name)) inidata.Remove(ent.Name);
        }
        /// <summary>
        /// Only check the name
        /// </summary>
        /// <param name="ent"></param>
        /// <returns></returns>
        public bool HasIniEnt(INIEntity ent)
        {
            return inidata.Keys.Contains(ent.Name);
        }
        public bool HasIniEnt(string name)
        {
            return inidata.Keys.Contains(name);
        }
        /// <summary>
        /// Find an IniEnt with specified name, return a NullEntity(not null) if not found
        /// </summary>
        /// <param name="entName"></param>
        /// <returns></returns>
        public INIEntity GetEnt(string entName)
        {
            if (inidata.Keys.Contains(entName)) return inidata[entName];
            return INIEntity.NullEntity;
            //throw new RSException.EntityNotFoundException(entName, FullName);
        }
        /// <summary>
        /// Find an IniEnt with specified name and remove it from file, return a NullEntity(not null) if not found
        /// </summary>
        /// <param name="entName"></param>
        /// <returns></returns>
        public INIEntity PopEnt(string entName)
        {
            INIEntity result = GetEnt(entName);
            RemoveEnt(result);
            return result;
        }
        /// <summary>
        /// Remove every item in this file
        /// </summary>
        public void ClearAllIniEnt()
        {
            inidata.Clear();
        }
        #endregion


        #region Public Calls - INIFile
        public Dictionary<string, INIEntity> IniDict
        {
            get { return inidata; }
            set { inidata = value; }
        }
        public INIEntity this[string name]
        {
            get { return GetEnt(name); }
            set { inidata[name] = value; }
        }
        public List<INIEntity> IniData
        {
            get { return inidata.Values.ToList(); }
        }
        public INIFileType INIType
        {
            get { return initype; }
            set { initype = value; }
        }
        #endregion
    }
}
