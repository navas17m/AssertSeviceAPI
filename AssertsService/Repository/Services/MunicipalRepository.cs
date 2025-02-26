using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;
using Microsoft.EntityFrameworkCore.Query.Internal;
namespace AssertsService.Repository.Services
{
    public class MunicipalRepository : IMunicipalRepository
    {
        private readonly AssertDBContext assertContext;
        public MunicipalRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<MunicipalDTO>> GetMunicipal()
        {
            return await (from M in assertContext.Municipals select new MunicipalDTO { 
                MunicipalId=M.MunicipalId,
                MunicipalName=M.MunicipalName
            }).ToListAsync();
                //assertContext.Municipals.ToListAsync();
        }
    }
}
