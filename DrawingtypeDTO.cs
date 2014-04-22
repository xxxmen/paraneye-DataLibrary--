
#region DrawingtypeDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DrawingtypeDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:44 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class DrawingtypeDTO : DTOBase
    {
        public int DrawingTypeID { get; set; }
        public string DrawingTypeName { get; set; }
        public string Keyword1 { get; set; }
        public string Keyword2 { get; set; }
        public string Keyword3 { get; set; }
        public string Comments { get; set; }
        

        // Constructor
        public DrawingtypeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
