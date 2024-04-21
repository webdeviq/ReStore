using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {

        private readonly StoreContext _context;

        public BasketController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<Basket>> GetBasket()
        {
            var basket = await _context.Baskets
                .Include(i => i.Items)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync(x => x.BuyerId == Request.Cookies["buyerId"]);

            if (basket is null)
            {
                return NotFound();
            }
            return basket;
        }

        [HttpPost]
        public async Task<ActionResult> AddItemToBasket(int productId, int quantity)
        {

            // Get the basket.
                // Create the basket
            // Get the product.
            // Add the itme.
            // Save the changes.

            return StatusCode(201);
        }

        [HttpDelete]
        public async Task<ActionResult> RemoveBasketItem(int productId, int quantity){
            // get basket.
            // remove the item or reduce quantity.
            // save changes.
            
            return Ok();
        }

    }
}