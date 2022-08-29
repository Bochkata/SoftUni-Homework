using System;
using System.Text;

namespace T05HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string titleOfArticle = Console.ReadLine();

            string contentOfArticle = Console.ReadLine();

            string commentForArticle = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            output.AppendLine("<h1>");
            output.AppendLine($"    {titleOfArticle}");
            output.AppendLine("</h1>");
            output.AppendLine("<article>");
            output.AppendLine($"    {contentOfArticle}");
            output.AppendLine("</article>");
           

            while (commentForArticle!= "end of comments")
            {
                output.AppendLine("<div>");
                output.AppendLine($"    {commentForArticle}");
                output.AppendLine("</div>");
                
                commentForArticle = Console.ReadLine();
            }



            Console.WriteLine(output);


        }
    }
}
