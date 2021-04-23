using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRealLibrary
{
    class Catgory
    {
        [ForeignKey("Author, Editor")]
        public int CatgoryID { get; set; }
        public string CatgoryName { get; set; }
        public Author AuthorID { get; set; }
        public Editor EditorID { get; set; }

    }
}
