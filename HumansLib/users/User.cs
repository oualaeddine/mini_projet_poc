using System;
using System.Runtime.Serialization;

namespace HumansLib
{
    [DataContract, Serializable]
    public class User : Human
    {
        [DataMember] public string matricule { get; set; }
    }
}