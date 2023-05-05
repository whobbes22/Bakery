using System;
using Bakery.Models;

namespace Bakery
{
  class program
  {
    static void Main()
    {
      Console.WriteLine(@" ______      _                   
| ___ \     | |                  
| |_/ / __ _| | _____ _ __ _   _ 
| ___ \/ _` | |/ / _ \ '__| | | |
| |_/ / (_| |   <  __/ |  | |_| |
\____/ \__,_|_|\_\___|_|   \__, |
                            __/ |
                           |___/ ");
      Console.WriteLine("\nWelcome to the Bakery\n");
      bool repeat = true;
      Bread bread = new Bread(5,2);
      Pastry pastry = new Pastry(2,4,"pastry");
      while(repeat)
      {
        Console.WriteLine("Enter 1 (1), if you are a customer and looking to buy.");
        Console.WriteLine("Enter 2 (2), if you are the owner and trying to update the menu.");
        Console.WriteLine("Enter 3 (3), if you accidently came into the store and want to leave.");
        string choice = Console.ReadLine();
        
        if(choice == "1")
        {
          ShowMenu(bread,pastry);
        } else if(choice == "2")
        {
          AddToMenu(pastry);
        } else
        {
          repeat = false;
        }
      }
      Console.WriteLine("C ya!");

    }

    static void AddToMenu(Pastry pastry)
    {
      Console.WriteLine("\nHere you will set up your menu prices");
      Console.WriteLine("To enter a new food enter the name of the food, the cost of the food, and the discount after buy 'x' amount of items getting 1 free of that item (0 means no discount)");
      // Console.WriteLine("Example input ->'chocolate cake',15,0 -> would make a chocolate cake priced at $15 with no discount");
      Console.Write("Enter Name of item: ");
      try
      {
      string key = Console.ReadLine();
      Console.Write("Enter Price of item: ");
      int price = int.Parse(Console.ReadLine());
      Console.Write("Enter Discount of Item: ");
      int dcPrice = int.Parse(Console.ReadLine());

      pastry.AddToMenuDictionary(key,price,dcPrice);
      }
      catch
      {
        Console.WriteLine("Sorry but it looks like this item is already added, or you mistyped the price or discount");
      }
      Console.WriteLine("Thank you, New item added to the menu.\n");
      Console.WriteLine("Would you like to add another item yes (y), no (n)");
      string choice = Console.ReadLine();
      if(choice == "y")
      {
        AddToMenu(pastry);
      } else
      {
        Console.WriteLine("Bye\n");
      }

    }

    static void ShowMenu(Bread bread,Pastry pastry)
    {


      Console.WriteLine($"Please Enter which item you would like to buy");
      Console.WriteLine($"Menu");
      Console.WriteLine($"The Price for bread (bread) is 5$ with a discount of buy 2 get 1 free");
      Console.WriteLine($"The Price for a pastry (pastry) is 2$ with a discount of buy 4 get 1 free");

      string choice = (Console.ReadLine()).ToLower();
      int amount = BuyAmount();

    }
   
   static int BuyAmount()
   {
    Console.WriteLine("Please Enter a number for how many you would like to buy. The discount will automatically be apllied.");
    Console.WriteLine("If you want to go back enter any other character");
    int choice;
    try
    {
      choice = int.Parse(Console.ReadLine());
    }
    catch
    {
      choice = -1;
    }
    return choice;
   }
  }
}