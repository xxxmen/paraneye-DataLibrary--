
#region ImportedfilenameDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ImportedfilenameDTO.cs
// Author: 
// Date: August-23-12
// Time: 3:33:07 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ImportedfilenameDTO : DTOBase
    {
        public int ImportedfilenameID { get; set; }
        public string FileType { get; set; }
        public string Importedfilename { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }

        // Constructor
        public ImportedfilenameDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
