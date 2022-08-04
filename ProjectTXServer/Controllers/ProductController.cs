using Microsoft.AspNetCore.Mvc;
using ProjectTXServer.Data;
using ProjectTXServer.Models;

namespace ProjectTXServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return product();
        }
        private List<ProductModel> product ()
        {
            var ProductQuery = from a in _context.Product
                            join b in _context.ProductInProductType on a.ProductId equals b.ProductId
                            join c in _context.ProductType on b.ProductTypeId equals c.ProductTypeId
                            select new { a, b, c };

        var query = ProductQuery.Select(x => new ProductModel()
        {
            ProductId = x.a.ProductId,
            ProductName = x.a.ProductName,
            ProductDescription = x.a.ProductDescription,
            ProductIntro = x.a.ProductIntro,
            ProductCover = x.a.ProductCover,
            ProductRate = x.a.ProductRate,
            ProductType = x.c.ProductTypeName
        }).ToList();
            return query;   
        }
    }
}