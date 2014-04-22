
#region ShiftDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ShiftDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:01 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ShiftDTO : DTOBase
    {
        public int ShiftID { get; set; }
        public int DaysWork { get; set; }
        public int DaysOff { get; set; }
        public int HoursPerDay { get; set; }
        public string ShiftStartDt { get; set; }
        public string ShiftName { get; set; }
        

        // Constructor
        public ShiftDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
