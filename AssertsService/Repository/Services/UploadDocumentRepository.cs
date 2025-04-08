using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class UploadDocumentRepository: IUploadDocumentRepository
    {
        private readonly AssertDBContext assertContext;
        public UploadDocumentRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<UploadDocumentDTO>> GetUploadDocuments(int userId)
        {
            return await (from AS in assertContext.UploadDocuments
                          where AS.UserId == userId && AS.IsActive == true
                          select new UploadDocumentDTO
                          {
                              UploadDocumentId = AS.UploadDocumentId,
                              Description = AS.Description,
                              Defects = AS.Defects,
                              FileName = (from M in assertContext.Uploads where M.UploadId == AS.UploadId select M.FileName).FirstOrDefault(),                            

                          }).ToListAsync();
        }
        //public async Task<UploadDocument> GetUploadDocument(int UploadDocumentId)
        //{
        //    return await assertContext.UploadDocuments.FirstOrDefaultAsync(T => T.UploadDocumentId == UploadDocumentId && T.IsActive == true);
        //}
        public async Task<UploadDocument> AddUploadDocument(UploadDocument UploadDocument)
        {
            var result = await assertContext.UploadDocuments.AddAsync(UploadDocument);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        //public async Task<UploadDocument> UpdateUploadDocument(UploadDocument UploadDocument)
        //{
        //    var result = await assertContext.UploadDocuments.FirstOrDefaultAsync(T => T.UploadDocumentId == UploadDocument.UploadDocumentId);
        //    if (result != null)
        //    {
        //        result.Requirement = UploadDocument.Requirement;
        //        result.Description = UploadDocument.Description;
        //        result.YesPartiallyNo = UploadDocument.YesPartiallyNo;
        //        result.Reasons = UploadDocument.Reasons;
        //        result.UploadId = UploadDocument.UploadId;
        //        await assertContext.SaveChangesAsync();
        //        return result;
        //    }
        //    return null;
        //}
        public void DeleteUploadDocument(int UploadDocumentId)
        {
            var result = assertContext.UploadDocuments.FirstOrDefault(T => T.UploadDocumentId == UploadDocumentId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
