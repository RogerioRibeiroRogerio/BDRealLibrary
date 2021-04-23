using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDRealLibrary
{
    class Editor
        
    {
        [ForeignKey("Author")]
        public int EditorID { get; set; }
        public string EditorName { get; set; }
        public string EditorAdress{ get; set; }
        public string EditorContact { get; set; }
        public Author AuthorID { get; set; }
    }
}
