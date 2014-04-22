using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class OrphanTagDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        public int CwpID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        public int DrawingNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskType { get; set; }
        public int MaterialCategoryID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PIDSingLine { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagDesc { get; set; }

        public OrphanTagDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
