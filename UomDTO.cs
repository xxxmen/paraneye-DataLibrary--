
#region UomDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: UomDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:04 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class UomDTO : DTOBase
    {
        public int UOMID { get; set; }
        public string UOMName { get; set; }
        

        // Constructor
        public UomDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
