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
        [ForeignKey("Catgory")]
        public int CatgoryID { get; set; }
        public string CatgoryName { get; set; }

    }
}
