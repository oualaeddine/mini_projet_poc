using OuveragesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace OuvragesCRUD
{
    public class IOuvragesCRUD : ICRUD
    {
        public bool delete(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;
            throw new NotImplementedException();
        }

        public LinkedList<object> getAll()
        {
            throw new NotImplementedException();
        }

        public object getById(int id)
        {
            throw new NotImplementedException();
        }

        public bool insert(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;

            throw new NotImplementedException();
        }

        public bool update(object obj)
        {
            Ouvrage ouvrage = (Ouvrage)obj;

            throw new NotImplementedException();
        }
    }
}
