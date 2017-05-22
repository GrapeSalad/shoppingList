using System.Collections.Generic;
namespace ShoppingList.Objects
{
  public class Items
  {
    private string _description;
    private static List<string> _instances = new List<string>{};

    public Items (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(_description);
    }
  }
}
