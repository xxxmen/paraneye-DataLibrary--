
#region RateDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: RateDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:59 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class RateDTO : DTOBase
    {
        public int RateID { get; set; }
        public int STRate { get; set; }
        public int OTRate { get; set; }
        public int DTRate { get; set; }
        public int TravelRate { get; set; }
        public int MobRate { get; set; }
        public int DeMobRate { get; set; }
        public int LOARate { get; set; }
        public int EmpClassID { get; set; }
        public int ProjectID { get; set; }
        

        // Constructor
        public RateDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
