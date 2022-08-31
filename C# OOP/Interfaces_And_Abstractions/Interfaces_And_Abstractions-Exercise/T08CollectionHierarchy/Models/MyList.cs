
using System.Linq;


namespace T08CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection
    {
      
        public override string Remove()
        {
            string element = Collection.FirstOrDefault();
            Collection.Remove(element);
            return element;
        }

        public int Used => Collection.Count;
    }
}
