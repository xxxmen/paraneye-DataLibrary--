
#region MateriallogDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: MateriallogDTO.cs
// Author: 
// Date: August-12-12
// Time: 8:57:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class MateriallogDTO : DTOBase
    {
        public int MaterialLogID { get; set; }
        public int MaterialID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        public int MaterialCategoryID { get; set; }
        public int ComponentID { get; set; }
        public int libID { get; set; }
        public int TaskTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int IntegerVar1 { get; set; }
        public int IntegerVar2 { get; set; }
        public int IntegerVar3 { get; set; }
        public int IntegerVar4 { get; set; }
        public int IntegerVar5 { get; set; }
        public double FloatVar1 { get; set; }
        public double FloatVar2 { get; set; }
        public double FloatVar3 { get; set; }
        public double FloatVar4 { get; set; }
        public double FloatVar5 { get; set; }
        public int BooleanVar1 { get; set; }
        public int BooleanVar2 { get; set; }
        public int BooleanVar3 { get; set; }
        public int BooleanVar4 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar4 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar5 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar6 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar7 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar8 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar9 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar10 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar11 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar12 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar13 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar14 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar15 { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comment { get; set; }
        public float East { get; set; }
        public float North { get; set; }
        public float Elevation { get; set; }
        

        // Constructor
        public MateriallogDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
