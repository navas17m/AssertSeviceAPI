using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;
using Microsoft.AspNetCore.Mvc;
namespace AssertsService.Repository.Services
{
    public class UserDetailsRepository:IUserDetailsRepository
    {
        private readonly AssertDBContext assertContext;
        public UserDetailsRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<UserDetailsDTO> GetUserDeatilsById(UserDetailsDTO userDeatils)
        {
            return await (from UD in assertContext.UserDetails
                          where UD.UserName == userDeatils.UserName && UD.Password == userDeatils.Password
                          select new UserDetailsDTO { 
                            UserDetailsId= UD.UserDetailsId,
                            UserName=UD.UserName                                                   
                          }).FirstOrDefaultAsync();
                //assertContext.UserDetails.FirstOrDefaultAsync(T => T.UserName == userDeatils.UserName && T.Password==userDeatils.Password);
        }
        
    }
}
