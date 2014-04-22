
#region WeekendholidayDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: WeekendholidayDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:05 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class WeekendholidayDTO : DTOBase
    {
        public int WeekendHolidayID { get; set; }
        public DateTime WeekendDt { get; set; }
        public int ShiftID { get; set; }
        

        // Constructor
        public WeekendholidayDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
