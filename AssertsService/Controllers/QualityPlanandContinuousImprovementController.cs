using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QualityPlanandContinuousImprovementController : ControllerBase
    {
        private readonly IQualityPlanandContinuousImprovementRepository QualityPlanandContinuousImprovementRepository;
        public QualityPlanandContinuousImprovementController(IQualityPlanandContinuousImprovementRepository _QualityPlanandContinuousImprovementRepository)
        {
            this.QualityPlanandContinuousImprovementRepository = _QualityPlanandContinuousImprovementRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetQualityPlanandContinuousImprovements(int id)
        {

            try
            {
                return Ok(await QualityPlanandContinuousImprovementRepository.GetQualityPlanandContinuousImprovements(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<QualityPlanandContinuousImprovement>> GetQualityPlanandContinuousImprovement(int id)
        {

            try
            {
                var result = await QualityPlanandContinuousImprovementRepository.GetQualityPlanandContinuousImprovement(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // POST api/<AssertRegisterController>        
        [HttpPost]
        public async Task<ActionResult<QualityPlanandContinuousImprovement>> AddQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement)
        {
            try
            {               
                if (QualityPlanandContinuousImprovement == null) return NotFound();
                var assertReg = await QualityPlanandContinuousImprovementRepository.AddQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<QualityPlanandContinuousImprovement>> UpdateQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement)
        {
            try
            {
                var assertReg = await QualityPlanandContinuousImprovementRepository.GetQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement.QualityPlanandContinuousImprovementId);
                if (assertReg == null) return NotFound();

                return await QualityPlanandContinuousImprovementRepository.UpdateQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteQualityPlanandContinuousImprovement(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                QualityPlanandContinuousImprovementRepository.DeleteQualityPlanandContinuousImprovement(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                //StatusCode(StatusCodes.Status500InternalServerError, "Error deleting asserts");
            }
        }
    }
}
