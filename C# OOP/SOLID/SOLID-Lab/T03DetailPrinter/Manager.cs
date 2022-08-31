using System;
using System.Collections.Generic;


namespace P03.DetailPrinter
{
    public class Manager : Employee, IPrintable
    {
        private List<string> documents;
        public Manager(string name) : base(name)
        {
            documents = new List<string>();
        }

        public IReadOnlyCollection<string> Documents => documents;

        public void AddDocuments(string doc)
        {
            if (!string.IsNullOrWhiteSpace(doc))
            {
                documents.Add(doc);
            }
        }
        public override void Print()
        {
            Console.WriteLine(base.ToString(), Environment.NewLine, string.Join(Environment.NewLine, documents));
        }
    }
}
