using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class StandardworkweekDTO : DTOBase
    {
        public int StandardWorkWeekID { get; set; }
        public int DayOfWeek { get; set; }
        public int CalendarID { get; set; }
        public decimal WorkHours { get; set; }
        public int StartHH { get; set; }
        public int StartMI { get; set; }
        public int StartSS { get; set; }
        public int FinishHH { get; set; }
        public int FinishMI { get; set; }
        public int FinishSS { get; set; }
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
        public StandardworkweekDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
