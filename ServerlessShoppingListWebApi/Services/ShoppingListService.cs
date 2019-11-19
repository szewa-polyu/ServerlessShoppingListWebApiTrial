using ServerlessShoppingListWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerlessShoppingListWebApi.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();
        
        public Dictionary<string, int> GetItemsFromShoppingList()
        {
            return _shoppingListStorage;
        }
        
        public void AddItemToShoppingList(ShoppingListItem shoppingListItem)
        {
            _shoppingListStorage.Add(shoppingListItem.Name, shoppingListItem.Quantity);
        }

        public void DeleteItemFromShoppingList(ShoppingListItem shoppingListItem)
        {
            _shoppingListStorage.Remove(shoppingListItem.Name); 
        }
    }
}
