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
        string matricule { get; set; }
    }
}
