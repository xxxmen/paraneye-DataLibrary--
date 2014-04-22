/*
 used for the report of WorkpackageSchedule.
 * called by EIS.ReportService library.
 */

using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class rptScheduledDateInfoDTO : DTOBase
    {
        public float HEWorkHours { get; set; }
        public float SWWorkHours { get; set; }

        public rptScheduledDateInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
