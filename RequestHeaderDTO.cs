using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element.Reveal.DataLibrary
{
    public class RequestHeaderDTO
    {
        public Int64 IDX { get; set; }
        public string UserID { get; set; }
        public string SessionKey { get; set; }
        public string OS { get; set; }
        public string RequestType { get; set; }
        public string RequestURI { get; set; }
        public string RequestBody { get; set; }
        public DateTime WriteDate { get; set; }

        public RequestHeaderDTO()
        {

        }
    }
}
