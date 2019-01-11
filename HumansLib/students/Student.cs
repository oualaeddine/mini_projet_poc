using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HumansLib
{
    [DataContract]
    public class Student :Human
    {
        [DataMember]
        public string n_carte { get; set; }
        [DataMember]
        public string niveau { get; set; }
    }
}
