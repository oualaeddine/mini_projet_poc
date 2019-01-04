using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HumansLib
{
    [DataContract]
    public class Human
    {
        [DataMember] public int id { get; set; }
        [DataMember] public string nom { get; set; }
        [DataMember] public string prenom { get; set; }
        [DataMember] public DateTime dateNaissance { get; set; }
        [DataMember] public string telephone { get; set; }
        [DataMember] public string email { get; set; }
        [DataMember] public string password { get; set; }
    }
}