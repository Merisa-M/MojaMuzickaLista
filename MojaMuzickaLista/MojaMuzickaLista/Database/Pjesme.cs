using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Database
{
    public class Pjesme
    {
        [Key]
        public int PjesmaID { get; set; }
        public string NazivPjesme { get; set; }
        public string NazivIzvodjaca { get; set; }
        public string Url { get; set; }

        public int Ocjena { get; set; }
        public bool? Favorit { get; set; }
        public DateTime DatumUnos { get; set; }

        public DateTime DatumEditovanja { get; set; }


        [ForeignKey("KateogorijaID")]
        public Kategorije Kategorije { get; set; }
        public int KategorijaID { get; set; }



    }
}
