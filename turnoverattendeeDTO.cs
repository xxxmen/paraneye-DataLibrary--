
#region TurnoverattendeeDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TurnoverattendeeDTO.cs
// Author: 
// Date: Sunday, December 8, 2013
// Time: 8:58:32 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class TurnoverattendeeDTO : DTOBase
    {
        public int TurnoverAttendeeID { get; set; }
        public int TurnoverID { get; set; }
        public int SystemID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int ContractorID { get; set; }
        public int DepartmentID { get; set; }
        public int PeronnelID { get; set; }
        public string PeronnelName { get; set; }
        public DateTime SignedDate { get; set; }
        

        // Constructor
        public TurnoverattendeeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
