using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MojaMuzickaLista.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Services
{
    public interface IKategorijeService
    {
        Task<List<Model.Kategorije>> GetAllKategorijeAsync(CancellationToken cancellationToken);

    }
    public class KategorijeService: IKategorijeService
    {
        private readonly MuzickaListaContext _context;
        protected readonly IMapper _mapper;

        public KategorijeService(MuzickaListaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Model.Kategorije>> GetAllKategorijeAsync(CancellationToken cancellationToken)
        {
            var list = await _context.Kategorije.ToListAsync(cancellationToken);
            return _mapper.Map<List<Model.Kategorije>>(list);
        }
    }
}
