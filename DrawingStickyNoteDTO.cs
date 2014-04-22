using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DrawingStickyNoteDTO : DTOBase
    {
        public int DrawingStickyNoteId { get; set; }
        public int DrawingId { get; set; }
        public decimal LocationX { get; set; }
        public decimal LocationY { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        // 추가 조회 컬럼
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }

        // Constructor
        public DrawingStickyNoteDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
