using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class UploadRepository:IUploadRepository
    {
        private readonly AssertDBContext assertContext;
        public UploadRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }      
       
        public async Task<int> AddFile(IFormFile file)
        {
            byte[] fileData;

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                fileData = memoryStream.ToArray();
            }
            Upload addFile = new Upload {FileName=file.FileName,FileData= fileData,UploadedDate=DateTime.Now };
            var result = await assertContext.Uploads.AddAsync(addFile);
            await assertContext.SaveChangesAsync();
            return result.Entity.UploadId;
        }
       
    }
}
