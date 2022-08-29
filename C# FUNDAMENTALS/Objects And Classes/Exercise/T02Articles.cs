using System;
using System.Linq;



namespace T02Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(input[0], input[1], input[2]);
           

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string EditOrChangeOrRename = command[0];
                string newName = command[1];

                switch (EditOrChangeOrRename)
                {
                    case "Edit": article.Content = newName;
                        break;
                    case "ChangeAuthor": article.Author = newName;
                        break;
                    case "Rename": article.Title = newName;
                        break;
                }
                
            }

            Console.WriteLine(article);

        }
        class Article

        {
            private string fieldTitle_;
            private string fieldContent_;
            private string fieldAuthor_;

            public Article(string ctorTitle, string ctorContent, string ctorAuthor)
            {
                Title = ctorTitle;
                Content = ctorContent;
                Author = ctorAuthor;

            }
            public string Title
            {
                get => fieldTitle_;
                set => fieldTitle_ = value;
            }
            public string Content
            {
                get => fieldContent_;
                set => fieldContent_ = value;
            }

            public string Author
            {
                get => fieldAuthor_;
                set => fieldAuthor_ = value;
            }
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }


    }
}
