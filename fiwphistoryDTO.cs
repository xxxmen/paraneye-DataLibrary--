using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class FiwphistoryDTO : DTOBase
    {
        public int FIWPHistoryID { get; set; }
        public int FiwpID { get; set; }
        public double CrewMembersAssigned { get; set; }
        public double WorkHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime CreatedDt { get; set; }


        // Constructor
        public FiwphistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
	}
}
