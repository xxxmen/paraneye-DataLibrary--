using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class P6ProjectDTO : DTOBase
    {
        public int P6ProjectObjectID { get; set; }
        public string P6ProjectID { get; set; }
        public string P6ProjectName { get; set; }
        //public string ProjectFileName { get; set; }

        // Constructor
        public P6ProjectDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    ///// <summary>
    ///// 프로젝트 파일 목록 리스팅용 DTO
    ///// </summary>
    //public class MppProjectDTO : P6ProjectDTO
    //{
    //    public string ProjectFileName { get; set; }

    //    public MppProjectDTO() : base()
    //    {

    //    }
    //}
}


