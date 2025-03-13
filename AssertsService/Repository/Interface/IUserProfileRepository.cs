using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserDetailsDTO>> GetUserDetails();
        Task<UserDetails> GetUserDetail(int userId);
        Task<UserDetails> AddUserDetails(UserDetails userDetails);
       
    }
}
