using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DailybrassreportDTO : DTOBase
    {
        public int DailyBrassReportId { get; set; }
        public int DailyBrassId { get; set; }
        [XmlElement(IsNullable = true)]
        public string DailyBrassReportCode { get; set; }
        public int UploadedFileInfoId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        // Constructor
        public DailybrassreportDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
