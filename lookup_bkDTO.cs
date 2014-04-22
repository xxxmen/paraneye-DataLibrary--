
#region Lookup_bkDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: Lookup_bkDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:38 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class Lookup_bkDTO 
    {
        public int LookupID { get; set; }
        public string LookupType { get; set; }
        public string LookupValue { get; set; }
        public int DisplayOrder { get; set; }
        public string Description { get; set; }
        public string LookupSubType { get; set; }
        public byte IsActive { get; set; }
        public int ExtraValue { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public Lookup_bkDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
