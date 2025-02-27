using AssertsService.Models;
using AssertsService.DTO;

namespace AssertsService.Repository.Interface
{
    public interface IUserDetailsRepository
    {
        Task<UserDetailsDTO> GetUserDeatilsById(UserDetailsDTO UserDeatils);
    }
}
