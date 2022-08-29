using System;
using System.Collections.Generic;
using System.Linq;

namespace T03Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfCommands = int.Parse(Console.ReadLine());

            List<Article> allArticles = new List<Article>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string articleTitle = inputArticle[0];
                string articleContent = inputArticle[1];
                string articleAuthor = inputArticle[2];

                Article article = new Article(articleTitle, articleContent, articleAuthor);

                allArticles.Add(article);
            }

            string criteriaToSort = Console.ReadLine();

            if (criteriaToSort == "title")
            {
                allArticles = allArticles.OrderBy(el => el.Title).ToList();
                //allArticles.Sort((item1, item2) => item1.Title.CompareTo(item2.Title));

            }
            else if (criteriaToSort == "content")
            {
                allArticles = allArticles.OrderBy(el => el.Content).ToList();
                //allArticles.Sort((item1, item2) => item1.Content.CompareTo(item2.Content));
            }
            else if (criteriaToSort == "author")
            {
                allArticles = allArticles.OrderBy(el => el.Author).ToList();
                //allArticles.Sort((item1, item2) => item1.Author.CompareTo(item2.Author));

            }



            foreach (Article item in allArticles)
            {
                Console.WriteLine(item);
            }

        }

        class Article
        {
            public Article(string ctorTitle, string ctorContent, string ctorAuthor)
            {
                Title = ctorTitle;
                Content = ctorContent;
                Author = ctorAuthor;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }


        }
    }
}
