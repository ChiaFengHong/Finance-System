using Finance.Domain.Entities;
using Finance.Domain.Enums;
using Finance.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Finance.API.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var category = new Category
            {
                Id = Guid.NewGuid(),
                Name = "餐飲",
                Type = TransactionType.Expense
            };

            _context.Categories.Add(category);

            _context.Transactions.Add(new Transaction
            {
                Id = Guid.NewGuid(),
                Amount = 100,
                Type = TransactionType.Expense,
                CategoryId = category.Id,
                Date = DateTime.Now,
                Note = "午餐"
            });

            _context.SaveChanges();

            return Ok("OK");
        }
    }
}
