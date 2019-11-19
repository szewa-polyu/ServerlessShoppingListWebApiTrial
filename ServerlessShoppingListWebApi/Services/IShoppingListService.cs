using ServerlessShoppingListWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessShoppingListWebApi.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemToShoppingList(ShoppingListItem shoppingListItem);
        void DeleteItemFromShoppingList(ShoppingListItem shoppingListItem);
    }
}
