using System.Collections.Generic;
using OuveragesLib;

namespace Utils
{
    public class Utils
    {
        public static LinkedList<Ouvrage> objectsListToOuvragesList(LinkedList<object> list)
        {
            var newList = new LinkedList<Ouvrage>();

            foreach (object obj in list)
            {
                newList.AddLast((Ouvrage) obj);
            }

            return newList;
        }

        public static bool isValid(Ouvrage ouvrage)
        {
            return true;
            //todo implement isValid(ouvrage)
        }
    }
}