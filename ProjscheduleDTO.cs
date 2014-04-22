
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


namespace Element.Reveal.DataLibrary
{
    public class ProjscheduleDTO : DTOBase
    {
        public int ProjectScheduleID { get; set; }
        public string DisplayName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string P6ProjectName { get; set; }
        public string P6ObjectID { get; set; }
        public string P6ScheduleID { get; set; }
        public int ProjectID { get; set; }
        public DateTime CreatedDt { get; set; }
        

        // Constructor
        public ProjscheduleDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
