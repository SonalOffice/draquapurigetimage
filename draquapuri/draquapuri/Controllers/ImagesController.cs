//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using draquapuri.Data;
//using draquapuri.Model;

//namespace draquapuri.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ImagesController : ControllerBase
//    {
//        private readonly DbContexts _context;

//        public ImagesController(DbContexts context)
//        {
//            _context = context;
//        }

//        // GET: api/Images
     
//        // PUT: api/Images/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
     

//        // POST: api/Images
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public Response AddImages(Images images)
//        {
//            if (!ModelState.IsValid)
//            {
//                return new Response { Status = Response.StatusCode, Message = "Please Enter valid data" };
//            }

//            Images inq = new Images();
//            inq.ImageName = images.ImageName;
//            inq.Image = images.Image;
//            inq.ProductId = images.ProductId;
            
//            inq.CreatedDate = DateTime.Now;

//            _context.Images.Add(inq);
//            _context.SaveChanges();

//            if (inq != null)
//            {
//                return new Response { Status = Response.StatusCode, Message = "Inquiry is inserted succesfully" };
//            }
//            else
//            {
//                return new Response { Status = Response.StatusCode, Message = "Inquiry is not inserted successfully" };

//            }
        
//    }

//        // DELETE: api/Images/5
     
//        private bool ImagesExists(int id)
//        {
//            return _context.Images.Any(e => e.ImageId == id);
//        }
//    }
//}
