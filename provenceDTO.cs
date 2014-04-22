
#region ProvenceDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProvenceDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:46 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class ProvenceDTO 
    {
        public int ProvenceID { get; set; }
        public string ProvenceName { get; set; }
        public int CountryID { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public ProvenceDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
