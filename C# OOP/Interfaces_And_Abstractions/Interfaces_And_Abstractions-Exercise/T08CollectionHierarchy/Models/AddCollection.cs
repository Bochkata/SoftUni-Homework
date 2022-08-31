
using System.Collections.Generic;
using T08CollectionHierarchy.Models;


namespace T08CollectionHierarchy
{
    public class AddCollection : Collection, IAddCollection
    {
        public AddCollection()
        {
            Collection = new List<string>();
        }

        public List<string> Collection { get; }
        public virtual int Add(string element)
        {
            Collection.Add(element);
            return Collection.Count - 1;
        }

    }
}
