
using System.Collections.Generic;


namespace T08CollectionHierarchy.Models
{
    public class Collection : ICollection
    {
        private IList<string> collection;
        public Collection()
        {
            collection = new List<string>();
        }

        public IList<string> List => collection;
    }
}
