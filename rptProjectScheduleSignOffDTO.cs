using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class rptProjectScheduleSignOffDTO : DTOBase
    {
        public string DepartmentName { get; set; }
        public string ProjectSchedule { get; set; }
        public DateTime AssignedDt { get; set; }
        public DateTime DueDt { get; set; }
        public DateTime UpdatedDt { get; set; }

        public rptProjectScheduleSignOffDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
