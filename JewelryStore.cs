using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace final_project_6
{
    [Serializable]
    public class JewelryStore
    {
        public string Address { get; set; }
        public List<JewelryItem> Items { get; set; }

        public JewelryStore()
        {
            Items = new List<JewelryItem>();
        }
    }
}
