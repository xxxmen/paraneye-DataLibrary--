using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class WorktimeDTO : DTOBase
    {
        public int WorkTimeID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public int StandardWorkWeekID { get; set; }
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
        public WorktimeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
