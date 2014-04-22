
#region Lookup_megDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: Lookup_megDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:39 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class Lookup_megDTO 
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
        public Lookup_megDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
