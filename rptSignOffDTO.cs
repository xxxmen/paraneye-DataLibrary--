using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptSignOffDTO : DTOBase
    {
        public int DepartmentID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisplayName { get; set; }
        public int ScheduleID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ScheduleName { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int SignOffOrder { get; set; }
        public int IsApproved { get; set; }
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        public int ActivityStatus { get; set; }//-1=Issue, 1=InProgress, 0=Complete
        public int RowNumber_CWP { get; set; }//for Report Grouping
        public int RowNumber_Department { get; set; }//for Report Grouping

        public rptSignOffDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
