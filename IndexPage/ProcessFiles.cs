using IndexPage.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IndexPage
{
    internal class ProcessFiles
    {
        internal static void CreateContentPage(List<HtmlFile> htmlFiles)
        {
            var outFile = Environment.CurrentDirectory + "\\Index.html";
            var outStream = File.Create(outFile);
            var sw = new StreamWriter(outStream);

            var title = GetCurrentFolder();
            string header = HtmlPage.CreateHeader(title);
            sw.WriteLine(header);

            foreach (var item in htmlFiles)
            {
                var fullFile = ($"{item.Folder}{item.Name}");

                string content = ProcessFiles.GetContent(fullFile);
                sw.WriteLine(content);
            }

            string footer = HtmlPage.CreateFooter();
            sw.WriteLine(footer);

            // flush and close
            sw.Flush();
            sw.Close();
        }

        internal static string GetContent(string fullFile)
        {

            var newLines = new StringBuilder();

            string fileName = Path.GetFileName(fullFile);
            string fileTitle = Path.GetFileNameWithoutExtension(fullFile);
            fileTitle = fileTitle.Replace("-f", string.Empty);

            // Console.WriteLine(fileName);

            if (File.Exists(fullFile))
            {
                var lines = File.ReadAllLines(fullFile);

                for (int i = 0; i < lines.Length - 1; i++)
                {
                    var line = lines[i];

                    if (line.ToLower().Contains("<h1"))
                    {
                        line = AddReference("h1", fileName, line);
                        newLines.Append($"{line}\n");
                    }
                    else if (line.ToLower().Contains("<h2"))
                    {
                        line = AddReference("h2", fileName, line);
                        newLines.Append($"{line}\n");
                    }
                }
            }

            return newLines.ToString();
        }

        private static string AddReference(string tag, string fileName, string line)
        {
            if (line.ToLower().Contains("id="))
            {
                var idValue = GetId(line);
                string replacement = "$1><a href=\"./" + fileName + "#" + idValue + "\">";

                if (tag == "h1")
                {
                    line = line.Replace("<h1", "<h3");
                    line = line.Replace("</h1>", "</a></h3>");
                    string pattern = @"(<h3 id=""[^""]+"")>";
                    line = Regex.Replace(line, pattern, replacement);
                    line = line.Replace("id=", "class=\"mb-3\" id=");
                }
                else if (tag == "h2")
                {
                    line = line.Replace("<h2", "<h4");
                    line = line.Replace("</h2>", "</a></h4>");
                    string pattern = @"(<h4 id=""[^""]+"")>";
                    line = Regex.Replace(line, pattern, replacement);
                    line = line.Replace("id=", "class=\"ml-5\" id=");
                }
            }

            return line;
        }

        internal static List<HtmlFile> GetHtmlList(string folder)
        {
            var dir = new DirectoryInfo(folder);
            var fileList = new List<string>();
            GetHtmlFiles(dir, fileList);

            var files = new List<HtmlFile>();

            var htmlFiles = new List<HtmlFile>();

            foreach (var file in fileList)
            {
                var htmlFile = new HtmlFile
                {
                    Name = Path.GetFileName(file),
                    Folder = folder,
                };

                htmlFiles.Add(htmlFile);
            }

            return htmlFiles;
        }

        private static List<string> GetHtmlFiles(DirectoryInfo d, List<string> fileList)
        {
            var files = d.GetFiles("*.html");

            foreach (FileInfo file in files)
            {
                var fileName = file.FullName;

                var newDirectory = Path.GetDirectoryName(fileName);
                var dirName = d.FullName;

                if (Path.GetFileName(fileName).Contains("-f"))
                {
                    fileList.Add(fileName);
                }
            }

            return fileList;
        }

        private static string GetId(string line)
        {
            string pattern = @"id=""([^""]+)""";
            string idValue = string.Empty;

            Match match = Regex.Match(line, pattern);

            if (match.Success)
            {
                idValue = match.Groups[1].Value;
            }

            return idValue;
        }

        private static string GetCurrentFolder()
        {
            var folder = Environment.CurrentDirectory;

            var iposn = folder.LastIndexOf("\\");
            folder = folder.Substring(iposn + 1);

            if (folder.Contains("-"))
            {
                folder = folder.Replace("-", " ");

                var textinfo = CultureInfo.CurrentCulture.TextInfo;

                folder = textinfo.ToTitleCase(folder);
            }

            return folder;
        }
    }
}
