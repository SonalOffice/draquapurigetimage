using draquapuri.Data;
using draquapuri.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace draquapuri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly DbContexts _context;

        public ProductImageController(DbContexts context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductImage>>> GetImage()
        {


            return await _context.ProductImage.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductImage>> GetImage(int id)
        {
            return await _context.ProductImage.FindAsync(id);
        }

        //        public IHostingEnvironment hostingEnvironment;

        //        public ProductImageController(IHostingEnvironment hostingEnv)
        //        {
        //            hostingEnvironment = hostingEnv;
        //        }

        //        [HttpPost]
        //        public ActionResult<string> UploadImage(ProductImage productImage)
        //        {
        //            try
        //            {
        //                var files = HttpContext.Request.Form.Files;
        //                if (files != null && files.Count > 0)
        //                {
        //                    foreach (var file in files)
        //                    {
        //                        FileInfo fi = new FileInfo(file.FileName);
        //                        var newfilename = "image_" + DateTime.Now.Millisecond + fi.Extension;
        //                        var path = Path.Combine("", hostingEnvironment.ContentRootPath = "\\images\\" + newfilename);
        //                        using (var stream = new FileStream(path, FileMode.Create))
        //                        {
        //                            file.CopyTo(stream);
        //                        }

        //                        //productImage.Image = path;
        //                        productImage.CreatedDate = DateTime.Now;
        //                        _context.ProductImage.Add(productImage);
        //                        _context.SaveChanges();
        //                    }
        //                    return "Saved Successfully";
        //                }
        //                else
        //                {
        //                    return "Select File";
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                return ex.Message;
        //            }
        //        }
        //[HttpGet]
        //public ActionResult<List<ProductImage>> GetProductImage()
        //{
        //    var result = _context.ProductImage.ToList();

        //    _context.ProductImage.

        //    return result;
        //}
    }
}


//[HttpPut("{id}")]
//public async Task<IActionResult> UpdateProduct(int id, Products product)
//{
//    if (id != product.ProductId)
//    {
//        return BadRequest();
//    }

//    var products = await _context.Products.FindAsync(id);
//    if (products == null)
//    {
//        return NotFound();
//    }

//    products.Name = product.Name;
//    products.ShortDescription = product.ShortDescription;
//    products.LongDescription = product.LongDescription;
//    products.NormalPrice = product.NormalPrice;
//    products.OfferPrice = product.OfferPrice;
//    products.CreatedDate = product.CreatedDate;


//    try
//    {
//        await _context.SaveChangesAsync();
//    }
//    catch (DbUpdateConcurrencyException) when (!ProductExists(id))
//    {
//        return NotFound();
//    }

//    return NoContent();
//}
//private bool ProductExists(int id)
//{
//    return _context.Products.Any(e => e.ProductId == id);
//}

