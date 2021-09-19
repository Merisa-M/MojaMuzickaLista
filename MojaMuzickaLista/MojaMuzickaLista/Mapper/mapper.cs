using AutoMapper;
using MojaMuzickaLista.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Mapper
{
    public class mapper : Profile
    {
        public mapper()
        {

            CreateMap<Database.Pjesme, Model.Pjesme>();
            CreateMap<Database.Pjesme,PjesmaAddRequest>().ReverseMap();
            CreateMap<Database.Kategorije, Model.Kategorije>();
        }
    }

}