
#region LibinsulpipefactorDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibinsulpipefactorDTO.cs
// Author: 
// Date: January-15-13
// Time: 4:02:35 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibinsulpipefactorDTO : DTOBase
    {
        public int LibInsulPipeFactorID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentType { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConditionVariable { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public int UOMLUID { get; set; }
        public decimal Factor { get; set; }
        [XmlElement(IsNullable = true)]
        public string MhrDescription { get; set; }

        public string MaterialCategory { get; set; }
        public string TaskCategory { get; set; }
        public string UOM { get; set; }
        public string ComponentTypeName { get; set; }
        public string TypeName { get; set; }
        public string FactorDes { get; set; }

        // Constructor
        public LibinsulpipefactorDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibinsulpipefactorPageTotal
    {
        public List<LibinsulpipefactorDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
