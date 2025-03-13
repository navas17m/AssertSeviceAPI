using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AssertDBContext assertContext;
        public UserProfileRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<UserDetailsDTO>> GetUserDetails( )
        {
            return await (from UD in assertContext.UserDetails  where UD.UserDetailsId!=4
                          select new UserDetailsDTO
                          {
                              UserDetailsId = UD.UserDetailsId,
                              UserName = UD.UserName,
                              Municipal=(from M in assertContext.Municipals where M.MunicipalId== UD.MunicipalId select M.MunicipalName).FirstOrDefault(),
                              SubMunicipal= (from M in assertContext.SubMunicipals where M.SubMunicipalId == UD.SubMunicipalId select M.SubMunicipalName).FirstOrDefault(),
                          }).Distinct().ToListAsync();
        }
        public async Task<UserDetails> GetUserDetail(int userDetailsId)
        {
            return await assertContext.UserDetails.FirstOrDefaultAsync(T => T.UserDetailsId == userDetailsId);
        }
        public async Task<UserDetails> AddUserDetails(UserDetails UserDetails)
        {
            var result = await assertContext.UserDetails.AddAsync(UserDetails);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
       
    }
}
