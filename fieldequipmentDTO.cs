
#region FieldequipmentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FieldequipmentDTO.cs
// Author: 
// Date: April-04-12
// Time: 5:41:26 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class FieldequipmentDTO : DTOBase
    {
        public int FieldEquipmentID { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public string Spec { get; set; }
        public string SystemType { get; set; }
        public string EquipDesc { get; set; }
        public int UOMLUID { get; set; }
        public decimal EstimatedManHours { get; set; }
        public int IsActive { get; set; }
        

        // Constructor
        public FieldequipmentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
