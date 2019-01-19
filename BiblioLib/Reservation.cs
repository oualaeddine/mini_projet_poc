using System;
using HumansLib;
using OuveragesLib;

namespace BiblioLib
{
    public class Reservation
    {
        public Human member { get; set; }
        public Ouvrage ouvrage { get; set; }
        public DateTime date { get; set; }
    }
}