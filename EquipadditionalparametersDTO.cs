
#region EquipadditionalparametersDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EquipadditionalparametersDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:45 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class EquipadditionalparametersDTO : DTOBase
    {
        public string TagNumber { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNo { get; set; }
        public string SerialNo { get; set; }
        public string Classification { get; set; }
        public string Type { get; set; }
        public double Voltage { get; set; }
        public double AMP { get; set; }
        public int Phase { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public int UOMID { get; set; }
        public string Material { get; set; }
        

        // Constructor
        public EquipadditionalparametersDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
