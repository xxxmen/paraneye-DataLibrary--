
#region CountryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CountryDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:15 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class CountryDTO 
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public CountryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
