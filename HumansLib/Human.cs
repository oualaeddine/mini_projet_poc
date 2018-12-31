using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumansLib
{
    public class Human
    {
        protected int id { get; set; }
        protected string nom { get; set; }
        protected string prenom { get; set; }
        protected DateTime dateNaissance { get; set; }
        protected string telephone { get; set; }
        protected string email { get; set; }
    }
}
