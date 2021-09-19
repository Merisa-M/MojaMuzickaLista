using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MojaMuzickaLista.Database;
using MojaMuzickaLista.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Services
{
    public interface IPjesmeService
    {
        Task<List<Model.Pjesme>> GetAllPjesmeAsync(CancellationToken cancellationToken);
        Task<Model.Pjesme> Insert(PjesmaAddRequest request, CancellationToken cancellationToken);
        Task<Model.Pjesme> Update(int id,PjesmaAddRequest request, CancellationToken cancellationToken);
        Task<Model.Pjesme> Delete(int id, CancellationToken cancellationToken);
        Task<List<Model.Pjesme>> GetByFiltersAsync(SearchPjesmaRequest request);


    }
    public class PjesmeService:IPjesmeService
    {
        private readonly MuzickaListaContext _context;
        protected readonly IMapper _mapper;

        public PjesmeService(MuzickaListaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Model.Pjesme>> GetAllPjesmeAsync(CancellationToken cancellationToken)
        {
            var list = await _context.Pjesme.Include(i=>i.Kategorije).ToListAsync(cancellationToken);
            return _mapper.Map<List<Model.Pjesme>>(list);
        }
        public async Task<Model.Pjesme> Insert(PjesmaAddRequest request,CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Database.Pjesme>(request);
            _context.Pjesme.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Model.Pjesme>(entity);
        }
        public async Task<Model.Pjesme> Update(int id,PjesmaAddRequest request, CancellationToken cancellationToken)
        {
            var entity = await _context.Pjesme.FindAsync(new object[] { id }, cancellationToken);
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync(cancellationToken);

            return _mapper.Map<Model.Pjesme>(entity);
        }
        public async Task<Model.Pjesme> Delete(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Pjesme.FindAsync(new object[] { id }, cancellationToken);
            _context.Pjesme.Remove(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<Model.Pjesme>(entity);
        }
        public async Task<List<Model.Pjesme>> GetByFiltersAsync(SearchPjesmaRequest request)
        {
            var entity = _context.Set<Database.Pjesme>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.NazivPjesme))
            {
                entity = entity.Where(x => x.NazivPjesme.Contains(request.NazivPjesme)).OrderBy(c => c.NazivPjesme);
            }
            var list = await entity.ToListAsync();

            return _mapper.Map<List<Model.Pjesme>>(list);
            //var query = _context.Pjesme.Where(p => p.NazivPjesme.ToLower().Trim().StartsWith(request.NazivPjesme.ToLower().Trim()) 
            //   || string.IsNullOrWhiteSpace(request.NazivPjesme));

            //var count = await query.CountAsync(cancellationToken);
            //var list = await query.ToListAsync(cancellationToken);
            //var data = _mapper.Map<List<Model.Pjesme>>(list);

            //return _mapper.Map<List<Model.Pjesme>>(data);

        }
    }
}
