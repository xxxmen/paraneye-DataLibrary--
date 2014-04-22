using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class CalendarDTO : DTOBase
    {
        public int CalendarID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CalendarName { get; set; }
        public int P6CalendarID { get; set; }
        //2014-03-20 add
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }

        // Constructor
        public CalendarDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
