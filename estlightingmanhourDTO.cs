
#region EstlightingmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EstlightingmanhourDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:22 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class EstlightingmanhourDTO 
    {
        public int EstLightingManhourID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int UOMID { get; set; }
        public decimal Manhour { get; set; }
        public int CostCodeID { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public EstlightingmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
