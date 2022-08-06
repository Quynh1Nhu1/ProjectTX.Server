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

        [HttpGet("{searchKey}")]
        public List<ProductModel> Search(string searchKey)
        {
            return search(searchKey);
        }
        [HttpGet]
        public List<ProductModel> GetAll()
        {
            return search();
        }
        private List<ProductModel> search(string searchKey = "")
        {
            
            var ProductQuery = from a in _context.Product
                               join b in _context.ProductInProductType on a.ProductId equals b.ProductId
                               join c in _context.ProductType on b.ProductTypeId equals c.ProductTypeId
                               join d in _context.ProductInGender on a.ProductId equals d.ProductId
                               join e in _context.Gender on d.GenderId equals e.GenderId

                               select new { a, b, c ,d,e};
            if(searchKey != "")
            {
                ProductQuery = ProductQuery
                    .Where(text => text.a.ProductName.Contains(searchKey) ||
                    text.c.ProductTypeName.Contains(searchKey) ||
                    text.e.GenderName.Contains(searchKey));
            }

            var query = ProductQuery.Select(x => new ProductModel()
            {
                ProductId = x.a.ProductId,
                ProductName = x.a.ProductName,
                ProductDescription = x.a.ProductDescription,
                ProductIntro = x.a.ProductIntro,
                ProductCover = x.a.ProductCover,
                ProductRate = x.a.ProductRate,
                ProductType = x.c.ProductTypeName,
                ProductGender = x.e.GenderName
            }).ToList();
            return query;
        }
    }
}