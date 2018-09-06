using System;

namespace ToDo
{
  public class Item
  {
    private string _listItem;

    public Item(string item)
    {
      _listItem = item;
    }

    public string GetListItem()
    {
      return _listItem;
    }
  }


  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Program is running.");
    }
  }
}
