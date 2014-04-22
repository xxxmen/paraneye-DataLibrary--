using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class rptTimeSheetTableDTO : DTOBase
    {
        public decimal StraightTime { get; set; }
        public decimal TimeAndHalf { get; set; }
        public decimal DoubleTime { get; set; }
        public decimal Amount { get; set; }
        public int ProgressID { get; set; }   
        public int FiwpID { get; set; }
        public int DepartStructureID { get; set; }
        public string PersonnelId { get; set; }
        public string FIWPName { get; set; }
        public string EmployeeFullName { get; set; }
        public string Description { get; set; }
        public string EmployeeCode { get; set; }
        public string Class { get; set; }
        public string ClientName { get; set; }
        public string Comments { get; set; }
        public int CostCodeID { get; set;}
        public string NetworkCode { get; set; }
        public string ActvityCode { get; set; }
        public string CostCode { get; set; }
        public string Activities { get; set; }
        public string Concern { get; set; }
        public string LookHead { get; set; }

        public rptTimeSheetTableDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
