
#region DrawingreferenceDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DrawingreferenceDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:43 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class DrawingreferenceDTO : DTOBase
    {
        public int DrawingReferenceID { get; set; }
        public int DrawingID { get; set; }
        public int RefDrawingID { get; set; }
        public string DrawingName { get; set; }

        // Constructor
        public DrawingreferenceDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
