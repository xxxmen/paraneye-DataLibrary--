
#region TurnoverDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TurnoverDTO.cs
// Author: 
// Date: Sunday, December 8, 2013
// Time: 8:58:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class TurnoverDTO : DTOBase
    {
        public int TurnoverID { get; set; }
        public int SystemID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int ContractorID { get; set; }
        public int StageLUID { get; set; }
        public DateTime CWD_Date { get; set; }
        public DateTime CC_Date { get; set; }
        public DateTime FWD_Date { get; set; }
        public DateTime MC_Date { get; set; }
        public DateTime TCCC_Date { get; set; }
        [XmlElement(IsNullable = true)]
        public string Originator { get; set; }

        [XmlElement(IsNullable = true)]
        public string ProjectName { get; set; }
        [XmlElement(IsNullable = true)]
        public string OwnerName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContractorName { get; set; }
        
        // Constructor
        public TurnoverDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class WalkdownDTOSet
    {
        public ProjectDTO projectDTO { get; set; }
        public List<TurnoverDTO> turnoverDTOS { get; set; }
        public List<TurnoverattendeeDTO> turnoverattendeeDTOS { get; set; }
        public List<QaqcformDTO> qaqcformDTOS { get; set; }
        public List<QaqcformdetailDTO> qaqcformdetailDTOS { get; set; }

        public WalkdownDTOSet()
        {
            projectDTO = new ProjectDTO();
            turnoverDTOS = new List<TurnoverDTO>();
            turnoverattendeeDTOS = new List<TurnoverattendeeDTO>();
            qaqcformDTOS = new List<QaqcformDTO>();
            qaqcformdetailDTOS = new List<QaqcformdetailDTO>();
        }
    }

    public class PunchDTOSet
    {
        public List<TurnoverDTO> turnoverDTOS { get; set; }
        public List<TurnoverattendeeDTO> turnoverattendeeDTOS { get; set; }
        public List<QaqcformDTO> qaqcformDTOS { get; set; }

        public PunchDTOSet()
        {
            turnoverDTOS = new List<TurnoverDTO>();
            turnoverattendeeDTOS = new List<TurnoverattendeeDTO>();
            qaqcformDTOS = new List<QaqcformDTO>();
        }
    }

}
