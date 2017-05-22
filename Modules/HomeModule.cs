using Nancy;
using ShoppingList.Objects;

namespace ShoppingList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_item.cshtml"];
      Get["/view_all_items"] = _ => {
        Items newItem = new Items(request.Query["new-item"]);
        return View["view_all_items.cshtml", newItem];
      }
    }
  }
}
