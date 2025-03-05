using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IUploadRepository
    {        
        Task<int> AddFile(IFormFile file);        
    }
}
