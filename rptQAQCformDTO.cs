using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptQAQCformDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string SystemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string Discipline { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ITRName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ITRNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string KeyValue { get; set; }
        [XmlElement(IsNullable = true)]
        public string AssembledDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartialCompetedDate { get; set; }       
        [XmlElement(IsNullable = true)]
        public string CompetedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ApprovedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string RejectedDate { get; set; }

        [XmlElement(IsNullable = true)]
        public int CompletedCnt { get; set; }
        [XmlElement(IsNullable = true)]
        public int RejectedCnt { get; set; }
        [XmlElement(IsNullable = true)]
        public int PartialCnt { get; set; }
        [XmlElement(IsNullable = true)]
        public int AssembledCnt { get; set; }

        public rptQAQCformDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
