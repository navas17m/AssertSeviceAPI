using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AssertsService.DTO;

namespace AssertsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsRepository userDetailslRepository;
        public UserDetailsController(IUserDetailsRepository _userDetailslRepository)
        {
            this.userDetailslRepository = _userDetailslRepository;
        }
        [HttpPost]
        public async Task<ActionResult<UserDetailsDTO>> GetUserDetails(UserDetailsDTO userDetailsDTO)
        {

            try
            {
                var result = await userDetailslRepository.GetUserDeatilsById(userDetailsDTO);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

    }
}
