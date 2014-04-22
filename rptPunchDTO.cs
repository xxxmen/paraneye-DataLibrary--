using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptPunchDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ItemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string Date { get; set; }
        [XmlElement(IsNullable = true)]
        public string MEGSuper { get; set; }
        [XmlElement(IsNullable = true)]
        public string MEGCSU { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string Desc { get; set; }       
        [XmlElement(IsNullable = true)]
        public string CAT { get; set; }
        [XmlElement(IsNullable = true)]
        public string ActionBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string Discipline { get; set; }
        [XmlElement(IsNullable = true)]
        public string FCDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        [XmlElement(IsNullable = true)]
        public string ScheduledTCCC { get; set; }
        [XmlElement(IsNullable = true)]
        public string CompleteDay { get; set; }
        [XmlElement(IsNullable = true)]
        public int Cnt { get; set; }

        public rptPunchDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
