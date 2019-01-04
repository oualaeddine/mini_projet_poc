using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Utils
    {

        public static LinkedList<Ouvrage> objectsListToOuvragesList(LinkedList<Object> list)
        {
            LinkedList<Ouvrage> newList;
            newList = new LinkedList<Ouvrage>();

            foreach(Object obj in list)
            {
                newList.AddLast((Ouvrage)obj);
            }
            return newList;
        }
    }
}
