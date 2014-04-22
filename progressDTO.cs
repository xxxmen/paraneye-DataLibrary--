
#region ProgressDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProgressDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:56 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProgressDTO : DTOBase
    {
        public int ProgressID { get; set; }
        public decimal AmountInstalled { get; set; }
        public int UOMID { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public int ComponentID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
        public int SDID { get; set; }
        public DateTime InstalledDate { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int CostCodeID { get; set; }
        public int OwnerCostCodeID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        public int IsCompleted { get; set; }

        public string TagNumber { get; set; }
        public string UOM { get; set; }
        public string MaterialCategory { get; set; }
        public string TaskCategory { get; set; }
        public string CWPName { get; set; }
        public string CostCode { get; set; }
        public int DrawingID { get; set; }
        public string DrawingName { get; set; }
        public int SystemID { get; set; }
        public string SystemName { get; set; }
        public decimal Qty { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableFromTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableToTag { get; set; }
        public int MaterialID { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialDesc { get; set; }
        public int LibEstManhrsID { get; set; }
        public decimal PercentComplete { get; set; }
        public decimal InstalledRate { get; set; }
        public int ProgressCount { get; set; }
        public int RFIID { get; set; }
        public int DrawingRevisionID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNo { get; set; }
        public decimal InstalledQtyRatio { get; set; }
        public decimal ActualInstalled { get; set; }
        [XmlElement(IsNullable = true)]
        public string EWO { get; set; }

        public double FloatVar1 { get; set; }
        public double FloatVar2 { get; set; }
        public double FloatVar3 { get; set; }
        public double FloatVar4 { get; set; }
        public double FloatVar5 { get; set; }
        public int IntegerVar1 { get; set; }
        public int IntegerVar2 { get; set; }
        public int IntegerVar3 { get; set; }
        public int IntegerVar4 { get; set; }
        public int IntegerVar5 { get; set; }
        public string StringVar1 { get; set; }
        public string StringVar2 { get; set; }
        public string StringVar3 { get; set; }
        public string StringVar4 { get; set; }
        public string StringVar5 { get; set; }
        public string StringVar6 { get; set; }
        public string StringVar7 { get; set; }
        public string StringVar8 { get; set; }
        public string StringVar9 { get; set; }
        public string StringVar10 { get; set; }
        public string StringVar11 { get; set; }
        public string StringVar12 { get; set; }
        public string StringVar13 { get; set; }
        public string StringVar14 { get; set; }
        public string StringVar15 { get; set; }
        public string StringVar16 { get; set; }
        public string StringVar17 { get; set; }
        public string StringVar18 { get; set; }
        public string StringVar19 { get; set; }
        public string StringVar20 { get; set; }
        public string StringVar21 { get; set; }
        public decimal DecimalVar1 { get; set; }
        public decimal DecimalVar2 { get; set; }
        public decimal DecimalVar3 { get; set; }
        public decimal DecimalVar4 { get; set; }
        public decimal DecimalVar5 { get; set; }
        public float FEast { get; set; }
        public float FNorth { get; set; }
        public float FElevation { get; set; }
        public float TEast { get; set; }
        public float TNorth { get; set; }
        public float TElevation { get; set; } 
        public decimal ComponentQty { get; set; }
        public int ComponentUOMLUID { get; set; }
        public string ComponentUOM { get; set; }
        
        public int VendorID { get; set; }
        public int TaskTypeLUID { get; set; }
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

        [XmlElement(IsNullable = true)]
        public string MaterialItemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string Material { get; set; }
        [XmlElement(IsNullable = true)]
        public string DetailTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }

        public int SIWPID { get; set; }

        // Constructor
        public ProgressDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class ProgressAssignment
    {
        public ProjectscheduleDTO schedule { get; set; }
        public FiwpDTO fiwp { get; set; }
        public List<MTODTO> progress { get; set; }
    }

    public class MTODTO : DTOBase
    {
        public int ProgressID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public int ComponentID { get; set; }        
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialCategory { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskCategory { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        public int SystemID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        public decimal Qty { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialDesc { get; set; }
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FIWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string JobNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentDesc { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentTaskType { get; set; }
        public DateTime InstalledDate { get; set; }
        public int UOMID { get; set; }
        public int SDID { get; set; }
        public int OwnerID { get; set; }
        public int OwnerCostCodeID { get; set; }
        public int CostCodeID { get; set; }
        public decimal PercentComplete { get; set; }
        public decimal InstalledRate { get; set; }
        public decimal AmountInstalled { get; set; }
        public decimal InstalledQtyRatio { get; set; }
        public int IsComplete { get; set; }
        public decimal TotalInstalledQtyRatio { get; set; }
        public decimal ActualInstalled { get; set; }
        public int TimeAllocationID { get; set; }
        public int ExtraVal1 { get; set; }
        public decimal ExtraVal2 { get; set; }
        public decimal ExtraVal3 { get; set; }
        public int GIdx { get; set; }
        public int GCnt { get; set; }
        //This is for Silverlight procedure
        public bool IsSelected { get; set; }
        public int IsCompleted { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
                
        public double FloatVar1 { get; set; }
        public double FloatVar2 { get; set; }
        public double FloatVar3 { get; set; }
        public double FloatVar4 { get; set; }
        public double FloatVar5 { get; set; }
        public int IntegerVar1 { get; set; }
        public int IntegerVar2 { get; set; }
        public int IntegerVar3 { get; set; }
        public int IntegerVar4 { get; set; }
        public int IntegerVar5 { get; set; }

        public string StringVar1 { get; set; }
        public string StringVar2 { get; set; }
        public string StringVar3 { get; set; }
        public string StringVar4 { get; set; }
        public string StringVar5 { get; set; }
        public string StringVar6 { get; set; }
        public string StringVar7 { get; set; }
        public string StringVar8 { get; set; }
        public string StringVar9 { get; set; }
        public string StringVar10 { get; set; }
        public string StringVar11 { get; set; }
        public string StringVar12 { get; set; }
        public string StringVar13 { get; set; }
        public string StringVar14 { get; set; }
        public string StringVar15 { get; set; }
        public string StringVar16 { get; set; }
        public string StringVar17 { get; set; }
        public string StringVar18 { get; set; }
        public string StringVar19 { get; set; }
        public string StringVar20 { get; set; }
        public string StringVar21 { get; set; }
        public decimal DecimalVar1 { get; set; }
        public decimal DecimalVar2 { get; set; }
        public decimal DecimalVar3 { get; set; }
        public decimal DecimalVar4 { get; set; }
        public decimal DecimalVar5 { get; set; }

        public float FEast { get; set; }
        public float FNorth { get; set; }
        public float FElevation { get; set; }
        public float TEast { get; set; }
        public float TNorth { get; set; }
        public float TElevation { get; set; }

        public int HydroGroupID { get; set; }

        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }

        public int TaskTypeLUID { get; set; }
        public int LibEstManhrsID { get; set; }

        public int SIWPID { get; set; }

        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        // Constructor
        public MTODTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class MTOPageTotal
    {
        public List<MTODTO> mto { get; set; }
        public int TotalPageCount { get; set; }
        public decimal TotalManhours { get; set; }
    }

    public class MTOAndDrawing
    {
        public List<MTODTO> mto { get; set; }
        public List<ComboBoxDTO> drawing { get; set; }
        public int TotalGroupPageCount { get; set; }
    }

    public class ProgressAssignmentResult
    {
        public List<ProjectscheduleDTO> Projectschedules { get; set; }
        public List<FiwpDTO> Fiwps { get; set; }
        public List<ProgressDTO> Progresses { get; set; }

        public ProgressAssignmentResult()
        {
            Projectschedules = new List<ProjectscheduleDTO>();
            Fiwps = new List<FiwpDTO>();
            Progresses = new List<ProgressDTO>();
        }
    }

    public class CollectionDTO : DTOBase
    {
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskCategoryCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskCategoryName { get; set; }  //MaterialCategory
        public int ProgressTypeId { get; set; }  //TaskCategoryID
        [XmlElement(IsNullable = true)]
        public string ProgressTypeName { get; set; }  //TaskCategory
        [XmlElement(IsNullable = true)]
        public int CostCodeID { get; set; }
        public string CostCode { get; set; }
        public string CostCodeName { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        public int SystemID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FIWPName { get; set; }
        public int TaskTypeId { get; set; }  //TaskTypeLUID
        [XmlElement(IsNullable = true)]
        public string TaskTypeName { get; set; }  //TaskType
        public int RuleOfCreditWeightID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RuleOfCredit { get; set; }
        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingTypeLUID { get; set; } //DrawingTypeCode
        [XmlElement(IsNullable = true)]
        public string DrawingType { get; set; }
        [XmlElement(IsNullable = true)]
        public string Module { get; set; }
        [XmlElement(IsNullable = true)]
        public string PANDID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProcessSystem { get; set; }

        public int MaterialID { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialName { get; set; } //material.Description

        // Constructor
        public CollectionDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }


   
}
