﻿namespace PaletteStudio.FileSystem
{
    public class TechnoPair : IRegistable
    {
        private string abst = "";
        public enum AbstractType
        {
            Default = 0,
            Name, RegName, UIName, IndexOnly, CsfName
        }
        public enum IndexType
        {
            Default = 0,
            Index, RegName, Name
        }


        #region Ctor - TechnoPair
        public TechnoPair(INIEntity ent, string index, AbstractType abstractType = AbstractType.RegName, IndexType indexType = IndexType.Index)
        {
            Index = index;
            Name = ent["Name"];
            RegName = ent.Name;
            UIName = ent["UIName"];
            switch (indexType)
            {
                default:
                case IndexType.Index:
                    abst = Index;
                    break;
                case IndexType.Name:
                    abst = Name;
                    Index = Name;
                    break;
                case IndexType.RegName:
                    abst = RegName;
                    Index = RegName;
                    break;
            }
            switch (abstractType)
            {
                default:
                case AbstractType.RegName:
                    abst += " " + RegName;
                    break;
                case AbstractType.Name:
                    abst += " " + Name;
                    break;
                case AbstractType.UIName:
                    abst += " " + UIName;
                    break;
                case AbstractType.IndexOnly:
                    abst += "";
                    break;
            }
        }
        public TechnoPair(string index, string regname)
        {
            Index = index;
            RegName = regname;
            abst = index + " " + regname;
        }
        #endregion


        #region Public Methods - TechnoPair
        public override string ToString()
        {
            return abst;
        }

        public void ResetAbst(AbstractType abstractType = AbstractType.RegName, IndexType indexType = IndexType.Index)
        {
            switch (indexType)
            {
                default:
                case IndexType.Index:
                    abst = Index;
                    break;
                case IndexType.Name:
                    abst = Name;
                    Index = Name;
                    break;
                case IndexType.RegName:
                    abst = RegName;
                    Index = RegName;
                    break;
            }
            switch (abstractType)
            {
                default:
                case AbstractType.RegName:
                    abst += " " + RegName;
                    break;
                case AbstractType.Name:
                    abst += " " + Name;
                    break;
                case AbstractType.UIName:
                    abst += " " + UIName;
                    break;
                case AbstractType.IndexOnly:
                    abst += "";
                    break;
            }
        }
        #endregion


        #region Public Calls - TechnoPair
        public string Index { get; set; } = "";
        public string Name { get; set; } = "";
        public string ID { get { return RegName; } }
        public string RegName { get; set; } = "";
        public string UIName { get; set; } = "";
        public static TechnoPair NonePair
        {
            get
            {
                TechnoPair ret = new TechnoPair("<none>", "<none>");
                ret.ResetAbst(AbstractType.IndexOnly, IndexType.Index);
                return ret;
            }
        }
        #endregion
    }
}
