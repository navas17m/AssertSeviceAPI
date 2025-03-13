using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AssertsService.DTO;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MunicipalController : ControllerBase
    {
        private readonly IMunicipalRepository municipalRepository;
        public MunicipalController(IMunicipalRepository _municipalRepository)
        {
            this.municipalRepository = _municipalRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<MunicipalDTO>> GetMunicipal()
        {

            try
            {
                return await municipalRepository.GetMunicipal();
            }
            catch (Exception)
            {
                return null;
                //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetSubMunicipals(int id)
        {

            try
            {
                return Ok(await municipalRepository.GetSubMunicipals(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

    }
}
