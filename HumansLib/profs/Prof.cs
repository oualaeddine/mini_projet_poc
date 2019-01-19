using System;
using System.Runtime.Serialization;

namespace HumansLib.profs
{
    [DataContract, Serializable]
    public class Prof : Human
    {
        [DataMember] public string matricule { get; set; }
    }
}