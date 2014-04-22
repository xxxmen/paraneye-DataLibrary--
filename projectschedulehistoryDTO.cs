
#region ProjscheduleDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjscheduleDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:57 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProjectscheduleHistoryDTO : DTOBase
    {
        public int ProjectScheduleHistoryID { get; set; }
        public int ProjectScheduleID { get; set; }
        public float CrewMembersAssigned { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime CreatedDt { get; set; }

        // Constructor
        public ProjectscheduleHistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
