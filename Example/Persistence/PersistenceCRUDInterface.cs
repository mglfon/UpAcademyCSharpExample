using System.Collections.Generic;
using ExampleClass.Model;

namespace ExampleClass.Persistence {
    public interface PersistenceCRUDInterface<T> where T : Person {
        public void Add (T obj);

        public List<T> GetAll ();

        public T FindByName (string name);

        // public T updateByName (string name, T obj);

        public void Remove (T obj);
    }
}