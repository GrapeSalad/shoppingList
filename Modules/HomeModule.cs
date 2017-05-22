using Nancy;
using System.Collections.Generic;
using ShoppingList.Objects;

namespace ShoppingList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_item.cshtml"];
      Get["/view_all_items"] = _ => {
        List<string> allItems = Items.GetAll();
        return View["view_all_items.cshtml", allItems];
      };
      Post["/items_added"] = _ => {
        Items newItem = new Items (Request.Form["new-item"]);
        newItem.Save();
        return View["items_added.cshtml", newItem];
      };
      Post["/items_cleared"] = _ => {
        Items.ClearAll();
        return View["items_cleared.cshtml"];
      };
    }
  }
}
