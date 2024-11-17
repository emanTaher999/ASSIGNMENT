using ASSIGNMENT.Models;
using ASSIGNMENT.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASSIGNMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthServices _authServices;

        // Constructor to inject the IAuthServices dependency
        public UserController(IAuthServices authServices)
        {
            _authServices = authServices;
        }
        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="model">Contains the registration data (e.g., FirstName, LastName, UserName, Email, Password)</param>

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            // Check if the provided model is valid (i.e., meets all validation criteria)
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Call the RegisterAsync method from the authentication service
            var result = await _authServices.RegisterAsync(model);

            // If the registration process was unsuccessful (user is not authenticated), return a BadRequest
            if (!result.ISAuthentecated)
                return BadRequest(result.Message); // Return an error message in the response

            // If registration is successful, return a success response (OK status)

            return Ok(result);
        }

        /// <summary>
        /// Authenticates a user and returns a token if login is successful.
        /// </summary>
        /// <param name="model">Contains the login data (e.g., Email, Password).</param>
        /// <returns>Returns a response with a token if authentication is successful.</returns>

        [HttpPost("Login")]
        public async Task<IActionResult> GetTokenAsync([FromBody] LoginModel model)
        {
            // Validate the login data model
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // Returns a BadRequest response if the login data is invalid

            // Call the LoginAsync method from the authentication service to authenticate the user
            var result = await _authServices.LoginAsync(model);

            // If authentication fails (user is not authenticated), return a BadRequest
            if (!result.ISAuthentecated)
                return BadRequest(result.Message); // Returns a BadRequest response if the login data is invalid

        // If authentication is successful, return the token or success message
            return Ok(result);// Returns the token or success data to the client
        }

    }
}
