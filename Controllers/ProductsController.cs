using Feature.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Feature.Data;

namespace Feature.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //Get Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
    }
}
