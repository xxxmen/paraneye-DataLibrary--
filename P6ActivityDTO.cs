using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{

    public class P6ActivityDTO : DTOBase
    {
        public int P6ActivityObjectID { get; set; }
        public string P6ActivityID { get; set; }
        public string P6ActivityName { get; set; }
        public string P6ProjectID { get; set; }
        public int P6ProjectObjectID { get; set; }
        public float P6RemainingDuration { get; set; }
        public DateTime? P6StartDate { get; set; }
        public DateTime? P6FinishDate { get; set; }
        public string P6WBSName { get; set; }
        public string P6WBSCode { get; set; }
        public int P6WBSObjectID { get; set; }
        public int P6ActivitySeq { get; set; }
        public int P6ActivityLevel { get; set; }
        public int P6ActivityIsWBS { get; set; }
        public int P6ParentObjectId { get; set; }
        public int CalendarObjectID { get; set; }
        public int CWPID { get; set; }
        public int MaterialCategoyrID { get; set; }
        public int ProjectScheduleID { get; set; }

        // Constructor
        public P6ActivityDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
