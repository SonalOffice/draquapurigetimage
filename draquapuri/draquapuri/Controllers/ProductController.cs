using draquapuri.Data;
using draquapuri.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace draquapuri.Controllers
{
    [Route("api/[controller]")]
  [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DbContexts _context;

        public ProductsController(DbContexts context)
       {
            _context = context;
        }

        //        GET: api/Products
        //       [HttpGet]
        //        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        //        {
        //            return await _context.Products.ToListAsync();
        //        }

        //        GET: api/Products/5
        //        [HttpGet("{id}")]
        //        public async Task<ActionResult<Products>> GetProducts(int id)
        //        {
        //            return await _context.Products.FindAsync(id);
        //        }


        //        [HttpPost]
        //        public Response AddProducts(Products product)
        //        {
        //            if (!ModelState.IsValid)
        //            {
        //                return new Response { Status = Response.StatusCode, Message = "Please Enter valid data" };
        //            }

        //            Products prod = new Products();
        //            prod.Name = product.Name;
        //            prod.ShortDescription = product.ShortDescription;
        //            prod.LongDescription = product.LongDescription;
        //            prod.NormalPrice = product.NormalPrice;
        //            prod.OfferPrice = product.OfferPrice;
        //            prod.CreatedDate = DateTime.Now;

        //            _context.Products.Add(prod);
        //            _context.SaveChanges();

        //            if (prod != null)
        //            {
        //                return new Response { Status = Response.StatusCode, Message = "Product is inserted succesfully" };
        //            }
        //            else
        //            {
        //                return new Response { Status = Response.StatusCode, Message = "Product is not inserted successfully" };

        //            }

        //            List<Images> imagelist = new List<Images>();
        //            if (product.Files.Count > 0)
        //            {
        //                foreach (var formFile in product.Files)
        //                {
        //                    if (formFile.Length > 0)
        //                    {
        //                        using (var memoryStream = new MemoryStream())
        //                        {
        //                            await formFile.CopyToAsync(memoryStream);
        //                            Upload the file if less than 2 MB
        //                            if (memoryStream.Length < 2097152)
        //                            {
        //                                based on the upload file to create Photo instance.
        //                                You can also check the database, whether the image exists in the database.
        //                                var newimage = new Images()
        //                                {

        //                                };
        //                                add the photo instance to the list.
        //                                imagelist.Add(newimage);
        //                            }
        //                            else
        //                            {
        //                                ModelState.AddModelError("File", "The file is too large.");
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            assign the photos to the Product, using the navigation property.
        //            prod.Images = imagelist;
        //            _context.Images.Add(prod);
        //            _context.SaveChanges();


        //        }

        //        [HttpDelete("{id}")]
        //        public async Task<ActionResult<Products>> DeleteProducts(int id)
        //        {
        //            var products = await _context.Products.FindAsync(id);
        //            _context.Products.Remove(products);
        //            await _context.SaveChangesAsync();

        //            return NoContent();
        //        }

        //        [HttpPut("{id}")]
        //        public async Task<IActionResult> UpdateProduct(int id, Products product)
        //        {
        //            if (id != product.ProductId)
        //            {
        //                return BadRequest();
        //            }

        //            var products = await _context.Products.FindAsync(id);
        //            if (products == null)
        //            {
        //                return NotFound();
        //            }

        //            products.Name = product.Name;
        //            products.ShortDescription = product.ShortDescription;
        //            products.LongDescription = product.LongDescription;
        //            products.NormalPrice = product.NormalPrice;
        //            products.OfferPrice = product.OfferPrice;
        //            products.CreatedDate = product.CreatedDate;


        //            try
        //            {
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException) when (!ProductExists(id))
        //            {
        //                return NotFound();
        //            }

        //            return NoContent();
        //        }
        //        private bool ProductExists(int id)
        //        {
        //            return _context.Products.Any(e => e.ProductId == id);
        //        }

       
       [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetInquries()
        {
            return await _context.Product.ToListAsync();
        }


       


    }
}
