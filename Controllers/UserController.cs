using Microsoft.AspNetCore.Mvc;
using SimpleOrderManagementSystem.DTOs;
using SimpleOrderManagementSystem.Models;
using SimpleOrderManagementSystem.Services;

namespace SimpleOrderManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;    
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserInputDTO userInputDTO) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {

                int ID = _userService.AddUser(userInputDTO);
                return Ok(new { Message = "User added successfully", UserId = ID });

            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = "An error occurred while adding the user", Error = ex.Message });
            
            }
        }


    }
}
