

using System.Linq;

namespace T08CollectionHierarchy
{
    public class AddRemoveCollection: AddCollection
    {
        public override int Add(string element)
        {
            Collection.Insert(0,element);
            return 0;
        }

        public virtual string Remove()
        {
            string element = Collection.LastOrDefault();
            Collection.Remove(element);
            return element;
        }
    }
}
