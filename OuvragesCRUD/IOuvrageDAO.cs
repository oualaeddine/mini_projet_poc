using OuveragesLib;
using System.Collections.Generic;

namespace OuvragesCRUD
{
    public interface IOuvrageDAO
    {
         bool delete(object obj)
    ;

         LinkedList<Ouvrage> find(object obj)
       ;

         LinkedList<Ouvrage> getAll()
   ;
         Ouvrage getById(int id)
    ;

         bool insert(object obj)
   ;

         bool update(object obj)
  ;
    }
}