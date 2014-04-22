using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptSystemTagDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PIDSingLine { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagDesc { get; set; }
        [XmlElement(IsNullable = true)]
        public string Loop { get; set; }

        public rptSystemTagDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
