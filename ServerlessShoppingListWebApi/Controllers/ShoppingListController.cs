using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerlessShoppingListWebApi.Models;
using ServerlessShoppingListWebApi.Services;

namespace ServerlessShoppingListWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemsToShoppingList([FromBody] ShoppingListItem shoppingListItem)
        {
            _shoppingListService.AddItemToShoppingList(shoppingListItem);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList([FromBody] ShoppingListItem shoppingListItem)
        {
            _shoppingListService.DeleteItemFromShoppingList(shoppingListItem);
            return Ok();
        }
    }
}