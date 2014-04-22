
#region DocumentmarkupmtoDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DocumentmarkupmtoDTO.cs
// Author: 
// Date: Sunday, December 1, 2013
// Time: 9:17:05 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class DocumentmarkupmtoDTO : DTOBase
    {
        public int DocumentMarkupMtoID { get; set; }
        public string DocumentMarkupURL { get; set; }
        public int SPCollectionID { get; set; }
        public int DrawingID { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        

        // Constructor
        public DocumentmarkupmtoDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
