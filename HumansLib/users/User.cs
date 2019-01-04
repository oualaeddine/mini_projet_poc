using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HumansLib
{
    [DataContract]
    public class User : Human
    {
        [DataMember]
        public string matricule { get; set; }
    }
}
