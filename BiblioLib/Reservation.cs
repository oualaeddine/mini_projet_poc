using HumansLib;
using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiblioLib
{
    public class Reservation
    {
        public Human member { get; set; }
        public Ouvrage ouvrage { get; set; }
        public DateTime date { get; set; }
    }
}
