using System.Collections.Generic;

namespace Utils
{
    public interface ICRUD
    {
        bool insert(object obj);
        bool update(object obj);
        bool delete(object obj);
        LinkedList<object> getAll();
        object getById(int id);
        LinkedList<object> find();
        LinkedList<object> find(object obj);
    }
}