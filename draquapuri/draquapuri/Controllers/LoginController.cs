//using draquapuri.Data;
//using draquapuri.Model;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace draquapuri.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class LoginController : ControllerBase
//    {
//        private readonly DbContexts _context;

//        public LoginController(DbContexts context)
//        {
//            _context = context;
//        }


//        [HttpPost]
//        public Response Login(Login login)
//        {

//            var log = _context.Login.Where(x => x.Phone.Equals(login.Phone) && x.Password.Equals(login.Password)).FirstOrDefault();


//            if (log != null)
//            {

//                return new Response { Status = Response.StatusCode, Message = "Login Successfully" };

//            }
//            else
//            {
//                return new Response { Status = Response.StatusCode, Message = "User or password is incorrect" };
//            }
//        }

        
//    }
//}
