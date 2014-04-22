
#region MaterialDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: MaterialDTO.cs
// Author: 
// Date: April-01-11
// Time: 3:10:04 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class MaterialDTO : DTOBase
    {
        public int MaterialID { get; set; }
        public int DataTypeLUID { get; set; }//2013-10-25
        public string TagNumber { get; set; }
        public int MaterialCategoryID { get; set; }
        public int ComponentID { get; set; }
        public int TaskTypeLUID { get; set; } 
        public int LibID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comment { get; set; }
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
        public string StringVar16 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar17 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar18 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar19 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar20 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar21 { get; set; }

        public float FEast { get; set; }
        public float FNorth { get; set; }
        public float FElevation { get; set; }
        public float TEast { get; set; }
        public float TNorth { get; set; }
        public float TElevation { get; set; } 
        public string RefDrawing { get; set; }
        public string DetailDrawing { get; set; }
        public string Drawing { get; set; }
        public string DrawingRev { get; set; }

        public int HydroGroupID { get; set; }

        public decimal DecimalVar1 { get; set; }
        public decimal DecimalVar2 { get; set; }
        public decimal DecimalVar3 { get; set; }
        public decimal DecimalVar4 { get; set; }
        public decimal DecimalVar5 { get; set; }

        public int VendorID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }

        [XmlElement(IsNullable = true)]
        public string UDF1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string UDF2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string UDF3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string UDF4 { get; set; }
        [XmlElement(IsNullable = true)]
        public string UDF5 { get; set; }

        // Constructor
        public MaterialDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class MaterialCableDTO : DTOBase
    {
        public int MaterialID { get; set; }
        public string TagNumber { get; set; }
        public int MaterialCategoryID { get; set; }
        public int ComponentID { get; set; }
        public int LibID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comment { get; set; }
        public int CableTaskTypeLUID { get; set; }
        public int VendorLUID { get; set; }
        public int Conductor { get; set; }
        public int NoOfConnector { get; set; }
        public int NoOfCable { get; set; }
        public double InsulRating { get; set; }
        public double InsulVolt { get; set; }
        public double FloatVar3 { get; set; }
        public double FloatVar4 { get; set; }
        public double FloatVar5 { get; set; }
        public int FromTagCutIn { get; set; }
        public int ToTagCutIn { get; set; }
        public int FromTagTerm { get; set; }
        public int ToTagTerm { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableLibName { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string AWG { get; set; }
        [XmlElement(IsNullable = true)]
        public string Shield { get; set; }
        [XmlElement(IsNullable = true)]
        public string TBStarTeckExtreamCatNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string ReelNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string FromTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string ToTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string TrayRouting { get; set; }
        [XmlElement(IsNullable = true)]
        public string SourceConnector { get; set; }
        [XmlElement(IsNullable = true)]
        public string DestinationConnector { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringVar15 { get; set; }

        // Constructor
        public MaterialCableDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class MaterialRacewayDTO : DTOBase
    {
        public int MaterialID { get; set; }
        public string TagNumber { get; set; }
        public int MaterialCategoryID { get; set; }
        public int ComponentID { get; set; }
        public int LibID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comment { get; set; }

        public int RacewayTaskTypeLUID { get; set; }
        public int VendorLUID { get; set; }
        public int Series { get; set; }
        public int SiderailLen { get; set; }

        public double Width1 { get; set; }
        public double Width2 { get; set; }
        public double AngleDegree { get; set; }
        public double NominalRadius { get; set; }
        public double Length { get; set; }

        [XmlElement(IsNullable = true)]
        public string PartNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string Material { get; set; }
        [XmlElement(IsNullable = true)]
        public string FittingStyle { get; set; }
        [XmlElement(IsNullable = true)]
        public string Style { get; set; }
        [XmlElement(IsNullable = true)]
        public string BottonStyle { get; set; }
        [XmlElement(IsNullable = true)]
        public string FittingStyle2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string CoverType { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }

        // Constructor
        public MaterialRacewayDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

}
