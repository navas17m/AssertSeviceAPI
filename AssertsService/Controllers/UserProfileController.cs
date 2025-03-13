using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileRepository UserProfileRepository;
        public UserProfileController(IUserProfileRepository _userProfileRepository)
        {
            this.UserProfileRepository = _userProfileRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetUserDetails( )
        {

            try
            {
                return Ok(await UserProfileRepository.GetUserDetails());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<UserDetails>> GetUserDetail(int id)
        {

            try
            {
                var result = await UserProfileRepository.GetUserDetail(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // POST api/<AssertRegisterController>        
        [HttpPost]
        public async Task<ActionResult<UserDetails>> AddUserDetails(UserDetails UserDetails)
        {
            try
            {
                if (UserDetails == null) return NotFound();
                var assertReg = await UserProfileRepository.AddUserDetails(UserDetails);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

      
        //[HttpPut]
        //public async Task<ActionResult<BudgetApproval>> UpdateBudgetApproval(BudgetApproval BudgetApproval)
        //{
        //    try
        //    {
        //        var assertReg = await BudgetApprovalRepository.GetBudgetApproval(BudgetApproval.BudgetApprovalId);
        //        if (assertReg == null) return NotFound();

        //        return await BudgetApprovalRepository.UpdateBudgetApproval(BudgetApproval);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
        //    }
        //}

       
    }
}
