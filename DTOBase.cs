using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Element.Reveal.DataLibrary
{
    [DataContract]
    public abstract class DTOBase
    {
        [DataMember]
        public int DTOStatus { get; set; }
        [DataMember]
        public string ExceptionMessage { get; set; }

        // Xml Serialization Infrastructure
    }

}
