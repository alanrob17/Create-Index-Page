using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPage.Models
{
    internal class HtmlFile
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Folder { get; set; }
    }
}
