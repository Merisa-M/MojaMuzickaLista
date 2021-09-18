using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MojaMuzickaLista.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MojaMuzickaLista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijeController : ControllerBase
    {
        private readonly IKategorijeService _kategorijeService;
        public KategorijeController(IKategorijeService kategorijeService)
        {
            _kategorijeService = kategorijeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllKategorijeAsync(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _kategorijeService.GetAllKategorijeAsync(cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
