using System;
using System.Collections.Generic;

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
    static List<Item> biglist = new List<Item>();
    public static void WriteList()
    {
      Console.WriteLine("Welcome to Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (add/view)");
      var input = Console.ReadLine();
      if(input == "add" || input == "Add")
      {
        Console.WriteLine("Please enter the description for the new item");
        string description = Console.ReadLine();
        Item itemToAdd = new Item(description);
        biglist.Add(itemToAdd);
        Console.WriteLine("{0} has been added to your list.", description);
        WriteList();
      }
      else if (input == "view" || input == "View")
      {
        if (biglist.Count == 0)
        {
          Console.WriteLine("There are no items in your list.");
        }
        else
        {
          Console.WriteLine("Your list items are:");
          foreach (Item listItem in biglist)
          {
            Console.WriteLine(listItem.GetListItem());
          }
        }
        WriteList();
      }

    }

    public static void Main()
    {
      WriteList();
    }
  }
}
