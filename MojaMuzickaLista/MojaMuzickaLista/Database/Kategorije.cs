using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Database
{
    public class Kategorije
    {

        [Key]
        public int KategorijaID { get; set; }
        public string nazivKategorije { get; set; }

    }
}
