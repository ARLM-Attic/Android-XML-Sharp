﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidXml.Res
{
    public class ResXMLTree_startelement
    {
        public ResXMLTree_node Node { get; set; }
        public ResXMLTree_attrExt AttrExt { get; set; }
        public List<ResXMLTree_attribute> Attributes { get; set; }
    }
}
