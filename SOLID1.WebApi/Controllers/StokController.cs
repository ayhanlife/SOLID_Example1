using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLID1.Business.Services.Abstract;

namespace SOLID1.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StokController : ControllerBase
    {


        private readonly IStokService stokService;

        public StokController(IStokService stokService)
        {
            this.stokService = stokService;
        }

        [HttpGet(Name = "GetAllStock")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await stokService.StokKategoriUrunAciklamaListesi());
        }
    }
}
