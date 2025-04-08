using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UploadDocumentController : ControllerBase
    {
        private readonly IUploadDocumentRepository UploadDocumentRepository;
        public UploadDocumentController(IUploadDocumentRepository _UploadDocumentRepository)
        {
            this.UploadDocumentRepository = _UploadDocumentRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetUploadDocuments(int id)
        {

            try
            {
                return Ok(await UploadDocumentRepository.GetUploadDocuments(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<UploadDocument>> GetUploadDocument(int id)
        //{

        //    try
        //    {
        //        var result = await UploadDocumentRepository.GetUploadDocument(id);
        //        if (result == null) return NotFound();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
        //    }
        //}

        // POST api/<AssertRegisterController>        
        [HttpPost]
        public async Task<ActionResult<UploadDocument>> AddUploadDocument(UploadDocument UploadDocument)
        {
            try
            {               
                if (UploadDocument == null) return NotFound();
                var assertReg = await UploadDocumentRepository.AddUploadDocument(UploadDocument);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        //[HttpPut]
        //public async Task<ActionResult<UploadDocument>> UpdateUploadDocument(UploadDocument UploadDocument)
        //{
        //    try
        //    {
        //        var assertReg = await UploadDocumentRepository.GetUploadDocument(UploadDocument.UploadDocumentId);
        //        if (assertReg == null) return NotFound();

        //        return await UploadDocumentRepository.UpdateUploadDocument(UploadDocument);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
        //    }
        //}

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteUploadDocument(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                UploadDocumentRepository.DeleteUploadDocument(id);
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
