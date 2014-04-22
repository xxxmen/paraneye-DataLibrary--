
#region TimesheetprogressDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TimesheetprogressDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:56 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class TimesheetprogressDTO 
    {
        public int TimeSheetProgressID { get; set; }
        public int TimeSheetID { get; set; }
        public int ProgressID { get; set; }
        public int TimeAllocationID { get; set; }
        

	    public int DTOStatus { get; set; }

        // Constructor
        public TimesheetprogressDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class TimeProgressLogDTO
    {
        public int DailyTimeProgressId;
        public string SubmitDate;
        public string IwpName;
        public int ProgressCount;
        public int CrewCount;
        public int StraightTime;
        public int OverTime;
        public int DoubleTime;
    }

    public class TimeProgressInputDTO
    {
        public int ComponentProgressId;
        public string ComponentName;
        public int ComponentId;
        public string NumberOfStructure;
        public int ID;
        public int ProgressTypeId;
        public string ProgressType;
        public decimal InstalledQtyRatio;
        public int TaskCategoryId;
        public string TaskCategory;
        public int TaskTypeId;
        public string TaskType;
        public int Quantity;
        public string UomCode;
        public string UOM;
    }


}
