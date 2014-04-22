
#region EquipmentlibDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EquipmentlibDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:21 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class EquipmentlibDTO 
    {
        public string CATALOGUENUMBER { get; set; }
        public string DESCRIPTION { get; set; }
        public string MATERIAL { get; set; }
        public string TYPE { get; set; }
        public double MATERIALITEMNUMBER { get; set; }
        public string MANUFACTORY { get; set; }
        public string ManHours { get; set; }
        public string SiteManHours { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public EquipmentlibDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
