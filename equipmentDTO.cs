
#region EquipmentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EquipmentDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:46 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class EquipmentDTO : DTOBase
    {
        public int EquipmentID { get; set; }
        public string EquipmentName { get; set; }
        public string PartNumber { get; set; }
        public int EquipTypeLUID { get; set; }
        public int WeightLB { get; set; }
        public int Voltage { get; set; }
        public int NamePlateHPKW { get; set; }
        [XmlElement(IsNullable = true)]
        public string PackageName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EquipDesc { get; set; }
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PNIDNumber { get; set; }
        public decimal EstimatedManHours { get; set; }
        

        // Constructor
        public EquipmentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
