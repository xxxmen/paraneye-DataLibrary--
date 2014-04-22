
#region ComponentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ComponentDTO.cs
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
    public class ComponentDTO : DTOBase
    {
        public int ComponentID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        public decimal Qty { get; set; }
        public int UOMLUID { get; set; }
        public int CWPID { get; set; }
        public int CWAID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int SystemID { get; set; }
        public int DrawingID { get; set; }
        public int DrawingRevisionID { get; set; }
        [XmlElement(IsNullable = true)]
        public string BOMNumber { get; set; }
        public int EWRCodeID { get; set; }
        public int RFIID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentDesc { get; set; }
        public int MaterialStatusLUID { get; set; }

        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string Catalogue { get; set; }
        [XmlElement(IsNullable = true)]
        public string AssociatedTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string Location { get; set; }
        [XmlElement(IsNullable = true)]
        public string SDItemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWAName { get; set; }

        public int ImportedfilenameID { get; set; }
        public int ImportedRow { get; set; }

        public int Org_ComponentID { get; set; }

        [XmlElement(IsNullable = true)]
        public string EWO { get; set; }

        // Constructor
        public ComponentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class ComponentAndMaterial
    {

        public List<MaterialDTO> materials { get; set; }
        public List<ComponentDTO> components { get; set; }
        public List<ProgressDTO> progresses { get; set; }
        public List<TagnumberdrawingDTO> tagnumberdrawings { get; set; }

        public ComponentAndMaterial()
        {
            components = new List<ComponentDTO>();
            materials = new List<MaterialDTO>();
            progresses = new List<ProgressDTO>();
            tagnumberdrawings = new List<TagnumberdrawingDTO>();
        }
    }

    public class ComponentPageTotal
    {
        public List<ComponentDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }

}
