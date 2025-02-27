using AssertsService.Models;
using AssertsService.DTO;

namespace AssertsService.Repository.Interface
{
    public interface IMunicipalRepository
    {
        Task<IEnumerable<MunicipalDTO>> GetMunicipal();
    }
}
