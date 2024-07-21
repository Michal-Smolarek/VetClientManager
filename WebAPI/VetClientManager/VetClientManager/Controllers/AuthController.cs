//using Microsoft.AspNetCore.Mvc;
//using VetClientManager.Services;

//namespace VetClientManager.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class AuthController : ControllerBase
//    {
//        private readonly IUserService _userService;
//        private readonly JwtTokenService _jwtTokenService;
//        public AuthController(IUserService userService, JwtTokenService jwtTokenService)
//        {
//            _userService = userService;
//            _jwtTokenService = jwtTokenService;
//        }
//        [HttpPost("login")]
//        public async Task<IActionResult> Login([FromBody] LoginModel model)
//        {
//            var user = await _userService.Authenticate(model.Username, model.Password);
//            if (user == null) return BadRequest(new { message = "Username or password is incorrect" });
//            var token = _jwtTokenService.GenerateJwtToken(user);
//            return Ok(new { user.Id, user.Username, Token = token });
//        }
//    }

//}
