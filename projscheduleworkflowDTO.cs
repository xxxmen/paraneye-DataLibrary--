
#region ProjscheduleworkflowDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjscheduleworkflowDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:45 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class ProjscheduleworkflowDTO 
    {
        public int ProjScheduleWorkFlowID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int DepartStructureID { get; set; }
        public byte IsApproved { get; set; }
        public DateTime AssignedDt { get; set; }
        public DateTime DueDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public string Comments { get; set; }
        public int ParentWorkFlowID { get; set; }
        public int AssignedBy { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public ProjscheduleworkflowDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
