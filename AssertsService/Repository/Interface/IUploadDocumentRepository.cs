using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IUploadDocumentRepository
    {
        Task<IEnumerable<UploadDocumentDTO>> GetUploadDocuments(int MunicipalId);
        //Task<UploadDocument> GetUploadDocument(int UploadDocumentId);
        Task<UploadDocument> AddUploadDocument(UploadDocument UploadDocument);       
        void DeleteUploadDocument(int UploadDocumentId);
    }
}
