using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRealLibrary
{
    class RentBook
    {
        public int RentBookID { get; set; }
        public Book BookID { get; set; }
        public Catgory CatgoryID { get; set; }
        public Editor EditorID { get; set; }
        public Author AuthorId { get; set; }
        public RentUser RentUserID { get; set; }
        public DateTime BookDateOut { get; set; }
        public DateTime BookDateIn { get; set; }

    }
}
