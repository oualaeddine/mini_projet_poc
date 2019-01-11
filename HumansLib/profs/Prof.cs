using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HumansLib.profs
{
    [DataContract]
    public class Prof :Human
    {
        [DataMember]
       public string matricule { get; set; }
    }
}
