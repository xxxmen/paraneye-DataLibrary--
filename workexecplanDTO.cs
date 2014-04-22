
#region WorkexecplanDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: WorkexecplanDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:53:01 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class WorkexecplanDTO 
    {
        public int WorkExecPlanID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int DescTypeLUID { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int FIWPID { get; set; }
        public string DetailDesc { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public WorkexecplanDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
