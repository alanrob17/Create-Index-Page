using IndexPage.Models;
using System.Collections.Immutable;

namespace IndexPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileDirectory = Environment.CurrentDirectory + @"\";

            List<HtmlFile> htmlFiles = ProcessFiles.GetHtmlList(fileDirectory);

            ProcessFiles.CreateContentPage(htmlFiles);

            Console.WriteLine("\nFinished...\n");
        }
    }
}
