
#region MtoissueconcernlogDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: MtoissueconcernlogDTO.cs
// Author: 
// Date: Sunday, December 1, 2013
// Time: 9:07:52 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class MtoissueconcernlogDTO : DTOBase
    {
        public int MTOIssueConcernLogID { get; set; }
        public int DrawingID { get; set; }
        public int ProjectId { get; set; }
        public string DisciplineCode { get; set; }
        public string Comments { get; set; }
        public string Updatedby { get; set; }
        public DateTime UpdatedDate { get; set; }
        

        // Constructor
        public MtoissueconcernlogDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
