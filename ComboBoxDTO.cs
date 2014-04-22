using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Element.Reveal.DataLibrary
{
    public class ComboBoxDTO : DTOBase
    {
        public int DataID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DataName { get; set; }

        [XmlElement(IsNullable = true)]
        public string ExtraValue1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue4 { get; set; }

        public int ParentID { get; set; }

        // Constructor
        public ComboBoxDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

        public ComboBoxDTO(int id, string name)
        {
            DataID = id;
            DataName = name;
        }
    }

    public class ComboCodeBoxDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string DataID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DataName { get; set; }

        [XmlElement(IsNullable = true)]
        public string ExtraValue1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue4 { get; set; }

        [XmlElement(IsNullable = true)]
        public string  ParentID { get; set; }

        // Constructor
        public ComboCodeBoxDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

        public ComboCodeBoxDTO(string id, string name)
        {
            DataID = id;
            DataName = name;
        }
    }

    public class LoopDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string DataID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DataName { get; set; }

        [XmlElement(IsNullable = true)]
        public string ExtraValue1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string ExtraValue4 { get; set; }

        public int ParentID { get; set; }

        // Constructor
        public LoopDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

        public LoopDTO(string id, string name)
        {
            DataID = id;
            DataName = name;
        }
    }

    public class ExtSchedulerDTO : DTOBase
    {
        public int Id { get; set; }
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }
        [XmlElement(IsNullable = true)]
        public string FavoriteColor { get; set; }
        [XmlElement(IsNullable = true)]
        public string ResourceId { get; set; }
        [XmlElement(IsNullable = true)]
        public string Title { get; set; }
        [XmlElement(IsNullable = true)]
        public string ResourceName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalMH { get; set; } 
        public int CrewMembers { get; set; }
        public int RowStyle { get; set; }
        [XmlElement(IsNullable = true)]
        public string Color { get; set; }
        public int ReferenceID { get; set; }
        public int IsProgressed { get; set; }

        //2014.03.27 add
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Constructor
        public ExtSchedulerDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

}