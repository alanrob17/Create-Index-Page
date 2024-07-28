using IndexPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPage
{
    internal class HtmlPage
    {
        internal static string CreateHeader(string title)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<!DOCTYPE html>\n");
            sb.Append("<html lang=\"en\">\n");
            sb.Append("<head>\n");
            sb.Append("<meta charset=\"UTF-8\">\n");
            sb.Append("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n");
            sb.Append("<meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n");
            sb.Append("<title>Notes</title>\n");
            sb.Append("<link href=\"assets/css/bootstrap.css\" rel=\"stylesheet\">\n");
            sb.Append("<!-- Custom styles for this template -->\n");
            sb.Append("<link href=\"assets/css/starter-template.css\" rel=\"stylesheet\">\n");
            sb.Append("<script src=\"https://cdn.jsdelivr.net/gh/google/code-prettify@master/loader/run_prettify.js?lang=css&amp;skin=sunburst\"></script>\n");
            sb.Append("<style type=\"text/css\">\n");
            sb.Append("html {\n");
            sb.Append("	font-size: 90.0%;\n");
            sb.Append("}\n");
            sb.Append("\n");
            sb.Append("h2 {\n");
            sb.Append("	margin-top: 60px;\n");
            sb.Append("}\n");
            sb.Append("\n");
            sb.Append("h4, h3 {\n");
            sb.Append("	padding-top: 40px!;		\n");
            sb.Append("}\n");
            sb.Append("\n");
            sb.Append("p {\n");
            sb.Append("	font-size: 1.2em;\n");
            sb.Append("}\n");
            sb.Append("h4 {\n");
            sb.Append("	font-size: 1.4em;\n");
            sb.Append("}\n");
            sb.Append("\n");
            sb.Append("img, pre.prettyprint {\n");
            sb.Append("	margin-top: 1.5em;\n");
            sb.Append("	margin-bottom: 1.5em;\n");
            sb.Append("}\n");
            sb.Append("h1, h2, h3, h4, h5, h6 {\n");
            sb.Append("    color:#007bff;\n");
            sb.Append("\n");
            sb.Append("}\n");
            sb.Append("blockquote {\n");
            sb.Append("    border-left: 4px solid #999;\n");
            sb.Append("    padding-left: 1rem;\n");
            sb.Append("    page-break-inside: avoid;\n");
            sb.Append("}\n");
            sb.Append(":target:before {\n");
            sb.Append("  content: \"\";\n");
            sb.Append("  display: block;\n");
            sb.Append("  height: 80px;\n");
            sb.Append("  margin: -80px 0 0;\n");
            sb.Append("}\n");
            sb.Append("</style>\n");
            sb.Append("<link rel=\"shortcut icon\" type=\"image/x-icon\" href=\"favicon.ico\" />\n");
            sb.Append("</head>\n");
            sb.Append("<body>\n");
            sb.Append("<header>\n");
            sb.Append("    <nav class=\"navbar navbar-expand-md navbar-dark fixed-top bg-primary\">\n");
            sb.Append("        <div class=\"container\">\n");
            sb.Append("            <a class=\"navbar-brand\" href=\"#\">Notes</a>\n");
            sb.Append("            <button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarCollapse\"\n");
            sb.Append("                aria-controls=\"navbarCollapse\" aria-expanded=\"false\" aria-label=\"Toggle navigation\">\n");
            sb.Append("                <span class=\"navbar-toggler-icon\"></span>\n");
            sb.Append("            </button>\n");
            sb.Append("            <div class=\"collapse navbar-collapse\" id=\"navbarCollapse\">\n");
            sb.Append("                <ul class=\"navbar-nav mr-auto\">\n");
            sb.Append("                    <li class=\"nav-item active\">\n");
            sb.Append("                        <a class=\"nav-link\" href=\"#\">Home</a>\n");
            sb.Append("                    </li>\n");
            sb.Append("                    <li class=\"nav-item\">\n");
            sb.Append("                        <a class=\"nav-link\" href=\"#\">About</a>\n");
            sb.Append("                    </li>\n");
            sb.Append("                </ul>\n");
            sb.Append("            </div>\n");
            sb.Append("        </div>\n");
            sb.Append("    </nav>\n");
            sb.Append("</header>\n");
            sb.Append("<div class=\"container\">\n");
            sb.Append($"<h2 class=\"mb-5\">{title}</h2>\n");
            sb.Append("\n");

            return sb.ToString();
        }
        
        internal static string CreateFooter()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("</div><!-- /.container -->\n");
            sb.Append("<!-- Bootstrap core JavaScript\n");
            sb.Append("================================================== -->\n");
            sb.Append("<!-- Placed at the end of the document so the pages load faster -->\n");
            sb.Append("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.12.0/styles/default.min.css\"/>\n");
            sb.Append("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.12.0/highlight.min.js\"/>\n");
            sb.Append("<script>hljs.initHighlightingOnLoad();</script>\n");
            sb.Append("\n");
            sb.Append("<script src=\"assets/js/jquery.min.js\"></script>\n");
            sb.Append("<script src=\"assets/js/bootstrap.min.js\"></script>\n");
            sb.Append("</body>\n");
            sb.Append("</html>\n");

            return sb.ToString();
        }
    }
}
