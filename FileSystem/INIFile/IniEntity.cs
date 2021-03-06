﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaletteStudio.Common;

namespace PaletteStudio.FileSystem
{
    [Serializable]
    public class INIEntity : IEnumerable<INIPair>
    {
        private readonly string name;
        private readonly string comment;
        private readonly string preComment;
        private Dictionary<string, INIPair> data = new Dictionary<string, INIPair>();
        private readonly INIEntType entitytype;


        #region Ctor - INIEntity
        public INIEntity() { }
        public INIEntity(string _name, string _preComment, string _comment)
        {
            name = _name;
            comment = _comment;
            preComment = _preComment;
            if (Constant.EntName.SystemEntity.Contains(_name)) entitytype = INIEntType.SystemType;
            else if (Constant.EntName.DictionaryList.Contains(_name)) entitytype = INIEntType.ListType;
            else if (Constant.EntName.MapList.Contains(_name)) entitytype = INIEntType.MapType;
            else entitytype = INIEntType.DefaultType;
        }
        public INIEntity(string _name, string packString, int startIndex)
        {
            name = _name;
            if (!string.IsNullOrEmpty(packString))
            {
                for (int i = 0; i < packString.Length; i += 70)
                {
                    int remain = packString.Length - i;
                    AddPair(new INIPair(startIndex.ToString(), packString.Substring(i, Math.Min(70, remain)), "", ""));
                    startIndex++;
                }
            }
            entitytype = INIEntType.ListType;
        }
        #endregion


        #region Public Methods - INIEntity
        /// <summary>
        /// Rename the key of each item as indexer, start from 0(def). Similar with IsoMapPack5.
        /// </summary>
        /// <param name="firstindex">Key num for first item</param>
        /// <returns></returns>
        public int Reorganize(int firstindex = 0)
        {
            Dictionary<string, INIPair> d = new Dictionary<string, INIPair>();
            foreach (INIPair p in data.Values)
            {
                p.Name = firstindex++.ToString();
                d[p.Name] = p;
            }
            data = d;
            return firstindex;
        }
        /// <summary>
        /// Merge two IniEnt, items with same key will be overwrite by new one.
        /// </summary>
        /// <param name="newEnt">New Ent</param>
        public void JoinWith(INIEntity newEnt)
        {
            if (entitytype == INIEntType.ListType)
            {
                int maxindex = Reorganize();
                foreach (INIPair p in newEnt)
                {
                    p.Name = maxindex++.ToString();
                    data[p.Name] = p;
                }
            }
            else
            {
                foreach (INIPair p in newEnt)
                {
                    data[p.Name] = p;
                }
            }
        }
        /// <summary>
        /// Transform entire IniEnt into an abstract struct, see TechnoPair. 
        /// Result Eg: "index value". Value depends on two types.
        /// Use along with LogicEditor.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <param name="indexType"></param>
        /// <returns></returns>
        public TechnoPair ToTechno(string index, TechnoPair.AbstractType type = TechnoPair.AbstractType.RegName, TechnoPair.IndexType indexType = TechnoPair.IndexType.Index)
        {
            TechnoPair tp = new TechnoPair(this, index, type, indexType);
            return tp;
        }
        /// <summary>
        /// Find and delete a specified Pair, return a NullPair(not null) if not found.
        /// </summary>
        /// <param name="pairKey"></param>
        /// <returns></returns>
        public INIPair PopPair(string pairKey)
        {
            if (data.Keys.Contains(pairKey))
            {
                INIPair p = data[pairKey];
                data.Remove(pairKey);
                return p;
            }
            else
            {
                return INIPair.NullPair;
            }
        }
        /// <summary>
        /// Add a Pair.
        /// </summary>
        /// <param name="p"></param>
        public void AddPair(INIPair p)
        {
            if (!data.Keys.Contains(p.Name)) data[p.Name] = p;
        }
        /// <summary>
        /// Discard all item index and merge the value into a list, works well with List-like Ent.
        /// Any repeated value will be discarded.
        /// Eg: [InfantryTypes]
        /// </summary>
        /// <returns></returns>
        public List<string> TakeValuesToList()
        {
            List<string> result = new List<string>();
            foreach (INIPair p in data.Values) if (!result.Contains(p.Value)) result.Add(p.Value);
            return result;
        }
        /// <summary>
        /// Find and return specified IniPair, return NullPair(not null) if not found.
        /// </summary>
        /// <param name="pairName"></param>
        /// <returns></returns>
        public INIPair GetPair(string pairName)
        {
            if (data.Keys.Contains(pairName)) return data[pairName];
            return INIPair.NullPair;
        }
        public bool HasPair(INIPair p)
        {
            return data.Keys.Contains(p.Name);
        }
        /// <summary>
        /// Try convert all Pair value into destinate type.
        /// Eg: string to bool, int, etc.
        /// Works well with IniInterpreter, not recommended using elsewhere
        /// </summary>
        public void ConvPairs()
        {
            if (entitytype != INIEntType.SystemType || entitytype != INIEntType.MapType)
                foreach (INIPair p in data.Values) p.ConvValue();
        }
        /// <summary>
        /// Remove a specified IniPair
        /// </summary>
        /// <param name="p"></param>
        public void RemovePair(INIPair p)
        {
            data.Remove(p.Name);
        }
        /// <summary>
        /// Discard all item index and merge all value into a single string, dedicated for IsoMapPack-like Ent
        /// </summary>
        /// <returns></returns>
        public string JoinString()
        {
            int num = data.Count * 70;
            StringBuilder sb = new StringBuilder(num);
            foreach (INIPair p in data.Values)
            {
                sb.Append(p.Value.ToString());
            }
            return sb.ToString();
        }
        #region Enumerator
        public IEnumerator<INIPair> GetEnumerator()
        {
            return data.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.Values.GetEnumerator();
        }
        #endregion
        #endregion


        #region Public Calls
        public Dictionary<string, INIPair> DictData { get { return data; } }
        public string Comment { get { return comment; } }
        public string PreComment { get { return preComment; } }
        public string Name { get { return name; } }
        public bool HasComment { get { return !string.IsNullOrEmpty(comment); } }
        /// <summary>
        /// Before converting, every value is string-type
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public dynamic this[string key]
        {
            get
            {
                if (data.Keys.Contains(key)) return data[key].Value;
                else return "";
            }
            set
            {
                data[key] = value;
            }
        }
        public List<INIPair> DataList { get { return data.Values.ToList(); } }
        public static INIEntity NullEntity { get { return new INIEntity("", "", ""); } }
        #endregion
    }
}
