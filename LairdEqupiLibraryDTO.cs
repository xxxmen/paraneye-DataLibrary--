
#region LairdEqupiLibraryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LairdEqupiLibraryDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:29 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class LairdEqupiLibraryDTO 
    {
        public string CATALOGUENUMBER { get; set; }
        public string DESCRIPTION { get; set; }
        public string MATERIAL { get; set; }
        public string TYPE { get; set; }
        public string MATERIALITEMNUMBER { get; set; }
        public string MANUFACTORY { get; set; }
        public string ManHours { get; set; }
        public double SiteManHours { get; set; }
        public string F9 { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public LairdEqupiLibraryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
