
#region LibMainTestDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibMainTestDTO.cs
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
    public class LibMainTestDTO 
    {
        public int LibMainID { get; set; }
        public string LibName { get; set; }
        public decimal Manhours { get; set; }
        public string LibDescription { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public LibMainTestDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
