
#region FiwpequipDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpequipDTO.cs
// Author: 
// Date: March-01-12
// Time: 4:53:07 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpequipDTO : DTOBase
    {
        public int FiwpEquipID { get; set; }
        public int FIWPID { get; set; }
        public int EquipmentID { get; set; }
        public string EquipDesc { get; set; }
        public int UseUnitLUID { get; set; }
        public DateTime StartUseDate { get; set; }
        public DateTime FinishUseDate { get; set; }
        public int StatusLUID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string EquipmentName { get; set; }
        public string Spec { get; set; }
        public string SystemType { get; set; }
        // 2014-2-20 add
        public int Qty { get; set; }



        // Constructor
        public FiwpequipDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
