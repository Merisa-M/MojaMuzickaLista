using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Database
{

    public partial class MuzickaListaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            MojaMuzickaLista.Database.Kategorije kategorije = new MojaMuzickaLista.Database.Kategorije()
            {
                KategorijaID = 1,
                nazivKategorije = "Pop"

            };
            modelBuilder.Entity<Kategorije>().HasData(kategorije);

            MojaMuzickaLista.Database.Pjesme pj= new MojaMuzickaLista.Database.Pjesme()
            {
                PjesmaID = 1,
                NazivPjesme = "naziv pjesme",
                NazivIzvodjaca="naziv izvodjaca",
                Url= "https://www.youtube.com/watch?v=RpyN9pFXUCg&list=RDRpyN9pFXUCg&start_radio=1",
                DatumUnos= new DateTime(2021, 07, 15),
                DatumEditovanja = new DateTime(2021, 07, 18),
                Favorit=true,
                KateogorijaID=1,
                Ocjena=4

            };
            modelBuilder.Entity<Pjesme>().HasData(pj);
            MojaMuzickaLista.Database.Pjesme pjesma = new MojaMuzickaLista.Database.Pjesme()
            {
                PjesmaID = 2,
                NazivPjesme = "naziv pjesme",
                NazivIzvodjaca = "naziv izvodjaca",
                Url = "https://www.youtube.com/watch?v=RpyN9pFXUCg&list=RDRpyN9pFXUCg&start_radio=1",
                DatumUnos = new DateTime(2021, 07, 15),
                DatumEditovanja = new DateTime(2021, 07, 18),
                Favorit = true,
                KateogorijaID = 1,
                Ocjena = 4

            };
            modelBuilder.Entity<Pjesme>().HasData(pjesma);

           

        }

    }
}