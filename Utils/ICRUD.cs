using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public interface ICRUD
    {
        bool insert(Object obj);
        bool update(Object obj);
        bool delete(Object obj);
        LinkedList<Object> getAll();
        Object getById(int id);

        LinkedList<Object> find(Object obj);
    }
}
