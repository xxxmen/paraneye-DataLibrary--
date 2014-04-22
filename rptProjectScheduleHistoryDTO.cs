using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class rptProjectScheduleHistoryDTO : DTOBase
    {
        public int ProjectScheduleID { get; set; }
        public string ProjectScheduleName { get; set; }
        public int PSHistoryID { get; set; }
        public int FIWPID { get; set; }
        public string FIWP { get; set; }
        public int FIWPHistoryID { get; set; }
        public float CrewMembersAssigned { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime P_CreatedDt { get; set; }
        public DateTime F_CreatedDt { get; set; }
        public DateTime FirstDate { get; set; }

        public rptProjectScheduleHistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
