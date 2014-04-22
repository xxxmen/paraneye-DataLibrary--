
#region AreaDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: AreaDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:38 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class AreaDTO : DTOBase
    {
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public string Description { get; set; }
        public string Abbrev { get; set; }
        public int Orders { get; set; }
        public int PlantID { get; set; }
        

        // Constructor
        public AreaDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
