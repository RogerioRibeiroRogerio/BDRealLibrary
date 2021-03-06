using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRealLibrary
{
    class Book
    {
        [ForeignKey("Catgory, Author, Editor")]
        public int BookID { get; set; }
        public Author AuthorID { get; set; }
        public Editor EditorID { get; set; }
        public Catgory CatgoryID { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string EditionData { get; set; }
    }
}
    

