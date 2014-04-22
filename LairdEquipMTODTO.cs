
#region LairdEquipMTODTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LairdEquipMTODTO.cs
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
    public class LairdEquipMTODTO 
    {
        public double ITEMNo { get; set; }
        public string CWP { get; set; }
        public string CWA { get; set; }
        public string LOCATION { get; set; }
        public string DRAWING { get; set; }
        public string REV { get; set; }
        public string ENGTAG { get; set; }
        public string TYPE { get; set; }
        public string TAGDESCRIPTION { get; set; }
        public string MATERIALITEMNUMBER { get; set; }
        public double QUANTITY { get; set; }
        public string UOM { get; set; }
        public string REFERENCEDRAWING { get; set; }
        public string REFDRWG { get; set; }
        public string REFREV { get; set; }
        public string REFDRWG1 { get; set; }
        public string REFREV1 { get; set; }
        public string REFDRWG2 { get; set; }
        public string REFREV2 { get; set; }
        public string STANDARDDETAIL { get; set; }
        public string REFREV3 { get; set; }
        public double UNITMANHRS { get; set; }
        public string F23 { get; set; }
        public double F24 { get; set; }
        public string F25 { get; set; }
        public double F26 { get; set; }
        public string F27 { get; set; }
        public string F28 { get; set; }
        public string F29 { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public LairdEquipMTODTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
