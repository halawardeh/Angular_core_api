using forLearning_angular_Core.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace forLearning_angular_Core.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryBatoolController : ControllerBase
    {

        private readonly MyDbContext _context;

        public CategoryBatoolController(MyDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult getAllCategories()
        //{
        //    var categories = _context.Categories.ToList();
        //    return Ok(categories);
        //}


        //[HttpGet]
        //public IActionResult getCategory(int id)
        //{
        //    id = 1;
        //    var categories = _context.Categories.SingleOrDefault(cat => cat.CategoryId==id);

        //    return Ok(categories);
        //}

        [HttpGet]
        public IActionResult getcategorybyName(string name)
        {
            var category = _context.Categories.SingleOrDefault(category => category.CategoryName==name);
            return Ok(category);
        }
    }
}
