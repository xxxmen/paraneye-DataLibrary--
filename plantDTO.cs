
#region PlantDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PlantDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:53 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class PlantDTO : DTOBase
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public string Description { get; set; }
        public int ECoordMin { get; set; }
        public int ECoordMax { get; set; }
        public int NCoordMin { get; set; }
        public int NCoordMax { get; set; }
        

        // Constructor
        public PlantDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
