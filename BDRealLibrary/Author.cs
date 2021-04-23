using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRealLibrary
{
    class Author

    {
        [ForeignKey("Catgory")]
        public int AuthorID { get; set; }
        public string NameAuthor { get; set; }
        public string NacionalatyAuthor { get; set; }
        public Catgory CatgoryID { get; set; }

    }
}
