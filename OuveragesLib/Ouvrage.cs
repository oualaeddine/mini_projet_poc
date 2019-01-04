using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OuveragesLib
{
    [DataContract]
    public class Ouvrage :Object
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string auteur { get; set; }
        [DataMember]
        public string keywords { get; set; }
        [DataMember]
        public string theme { get; set; }
        [DataMember]
        public string n_mat { get; set; }

    }
}
