using draquapuri.Data;
using draquapuri.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace draquapuri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase
    {
        private readonly DbContexts _context;

        public InquiryController(DbContexts context)
        {
            _context = context;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Inquiry>>> GetInquries()
        //{
        //    return await _context.Inquiry.ToListAsync();
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Inquiry>> GetProducts(int id)
        //{
        //    return await _context.Inquiry.FindAsync(id);
        //}

        [HttpPost]
        public Response AddInquiry(Inquiry inquiry)
        {
            if (!ModelState.IsValid)
            {
                return new Response { Status = Response.StatusCode, Message = "Please Enter valid data" };
            }

            Inquiry inq = new Inquiry();
            inq.Name = inquiry.Name;
            inq.Email = inquiry.Email;
            inq.Phone= inquiry.Phone;
            inq.Message = inquiry.Message;
            inq.CreatedDate = DateTime.Now;

            _context.Inquiry.Add(inq);
            _context.SaveChanges();

            if (inq != null)
            {
                return new Response { Status = Response.StatusCode, Message = "Inquiry is inserted succesfully" };
            }
            else
            {
                return new Response { Status = Response.StatusCode, Message = "Inquiry is not inserted successfully" };

            }
        }
    }
}
