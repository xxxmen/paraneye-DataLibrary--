using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class HolidayorexceptionDTO : DTOBase
    {
        public int HolidayOrExceptionID { get; set; }
        public DateTime HldyExpDate { get; set; }
        public int CalendarID { get; set; }
        public decimal WorkHours { get; set; }
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
        public HolidayorexceptionDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        } 
    }
}