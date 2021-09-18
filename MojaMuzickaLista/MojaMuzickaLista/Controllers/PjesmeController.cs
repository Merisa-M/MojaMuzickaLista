using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MojaMuzickaLista.Model;
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
    public class PjesmeController : ControllerBase
    {
        private readonly IPjesmeService _pjesmeService;
        public PjesmeController(IPjesmeService pjesmeService)
        {
            _pjesmeService = pjesmeService;
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAllPjesmeAsync(CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _pjesmeService.GetAllPjesmeAsync(cancellationToken));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Insert(PjesmaAddRequest request,CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _pjesmeService.Insert(request,cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,PjesmaAddRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _pjesmeService.Update(id,request, cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id,CancellationToken cancellationToken)
        {
            try
            {
                return Ok(await _pjesmeService.Delete(id,cancellationToken));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("GetByFiltersAsync")]
        [HttpGet]
        public async Task<IActionResult> GetByFiltersAsync(SearchPjesmaRequest request)
        {
            try
            {
                return Ok(await _pjesmeService.GetByFiltersAsync(request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
