
#region PartDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PartDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:41 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class PartDTO 
    {
        public int Part_ID { get; set; }
        public string PartCode { get; set; }
        public int Group_ID { get; set; }
        public string Description { get; set; }
        public decimal DailyRate { get; set; }
        public decimal Price { get; set; }
        public decimal HandlingRate { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weigth { get; set; }
        public string Abbrev { get; set; }
        public bool SetFlg { get; set; }
        public int Order { get; set; }
        public string AlumaNumber { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public PartDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
