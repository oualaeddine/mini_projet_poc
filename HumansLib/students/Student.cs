using System;
using System.Runtime.Serialization;

namespace HumansLib
{
    [DataContract, Serializable]
    public class Student : Human
    {
        [DataMember] public string n_carte { get; set; }
        [DataMember] public string niveau { get; set; }
    }
}