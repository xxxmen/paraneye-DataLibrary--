
#region LibMainChlidTestDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibMainChlidTestDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:34 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class LibMainChlidTestDTO 
    {
        public int LibCommonID { get; set; }
        public int LibMainID { get; set; }
        public int VendorID { get; set; }
        public int ID { get; set; }
        public string ChlidName { get; set; }
        public string ChlidValue { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public LibMainChlidTestDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
