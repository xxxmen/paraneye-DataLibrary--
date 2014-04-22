
#region LibgroundinglocknutDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibgroundinglocknutDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class LibgroundinglocknutDTO 
    {
        public int GroundingLockNutID { get; set; }
        public string GroundingLockNutName { get; set; }
        public double HubSize_in { get; set; }
        public int VendorID { get; set; }
        public string Description { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public LibgroundinglocknutDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
