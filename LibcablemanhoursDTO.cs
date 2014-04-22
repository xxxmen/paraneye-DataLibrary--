
#region LibcablemanhoursDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibcablemanhoursDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:47 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LibcablemanhoursDTO : DTOBase
    {
        public int LibCableManhoursID { get; set; }
        public int CableType1LUID { get; set; }
        public int CableType2LUID { get; set; }
        public float Voltage { get; set; }
        public float ManHours { get; set; }
        public float ManHours_TermFrom { get; set; }
        public float ManHours_TermTo { get; set; }
        public string Description { get; set; }
        public int UOMID { get; set; }
        

        // Constructor
        public LibcablemanhoursDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
