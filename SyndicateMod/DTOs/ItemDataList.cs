﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SyndicateMod.DTOs
{
    public class ItemDataList
    {
        [XmlArray("ItemList")]
        public List<ItemData> Items { get; set; }
    }
}