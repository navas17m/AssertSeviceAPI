using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AssertsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IUploadRepository uploadRepository;
        public FileUploadController(IUploadRepository _UploadRepository)
        {
            this.uploadRepository = _UploadRepository;
        }

        [HttpPost]
        public async Task<ActionResult<int>> UploadFile(IFormFile file)
        {
            try
            {
                if (file == null) return NotFound();
                int uploadId = await uploadRepository.AddFile(file);
                return uploadId;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        //private readonly string _connectionString = "Data Source=(local);Initial Catalog=AssertService;Encrypt=False;Trusted_Connection=True;";

        //[HttpPost]
        //public async Task<IActionResult> UploadFile(IFormFile file)
        //{
        //    int id = 0;
        //    if (file == null || file.Length == 0)
        //    {
        //        return BadRequest("No file uploaded.");
        //    }

        //    try
        //    {
        //        byte[] fileData;
               
        //        using (var memoryStream = new MemoryStream())
        //        {
        //            await file.CopyToAsync(memoryStream);
        //            fileData = memoryStream.ToArray();
        //        }

        //        using (SqlConnection conn = new SqlConnection(_connectionString))
        //        {
                   
        //            await conn.OpenAsync();
        //            string query = "INSERT INTO Uploads (FileName, FileData,UploadedDate) OUTPUT INSERTED.UploadId VALUES (@FileName, @FileData,@UploadedDate)";
        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@FileName", file.FileName);
        //                cmd.Parameters.AddWithValue("@FileData", fileData);
        //                cmd.Parameters.AddWithValue("@UploadedDate", DateTime.Now.ToShortTimeString());
        //                id = Convert.ToInt32(cmd.ExecuteScalarAsync());
        //            }
        //        }

        //        return Ok(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, "Internal server error: " + ex.Message);
        //    }
        //}


    }
}
