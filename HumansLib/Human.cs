using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumansLib
{
    public class Human
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
    }
}
