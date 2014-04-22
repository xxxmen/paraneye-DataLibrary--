
#region FiwpmanpowerDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpmanpowerDTO.cs
// Author: 
// Date: October-21-11
// Time: 4:36:28 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class FiwpmanpowerDTO : DTOBase
    {
        public int FIWPManPowerID { get; set; }
        public int FIWPID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CrewSize { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int ProjectScheduleID { get; set; }
        

        // Constructor
        public FiwpmanpowerDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
