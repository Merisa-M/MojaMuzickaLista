using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MojaMuzickaLista.Model
{
    public class PjesmaAddRequest
    {
        public string NazivPjesme { get; set; }  
        public string NazivIzvodjaca { get; set; }
        public string Url { get; set; }
        public int Ocjena { get; set; }
        public bool Favorit { get; set; }
        public DateTime DatumUnos { get; set; }
        public DateTime DatumEditovanja { get; set; }
        public int KategorijaID { get; set; }
    }
}
