
#region LibscaffoldpartDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibscaffoldpartDTO.cs
// Author: 
// Date: October-26-11
// Time: 5:28:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LibscaffoldpartDTO : DTOBase
    {
        public int LibScaffoldPartID { get; set; }
        public string PartCode { get; set; }
        public int ScaffoldTypeLUID { get; set; }
        public string Description { get; set; }
        public decimal DailyRate { get; set; }
        public decimal CostPrice { get; set; }
        public decimal HandlingRate { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Weigth { get; set; }
        public string Abbrev { get; set; }
        public int SetFlg { get; set; }
        public int Order { get; set; }
        public string AlumaNumber { get; set; }
        

        // Constructor
        public LibscaffoldpartDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
