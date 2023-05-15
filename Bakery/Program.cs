using System;
using System.Collections.Generic;
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
    
      //Bread bread = new Bread(5,2);
      Pastry bread = new Pastry(5,2,"bread");
      Pastry pastry = new Pastry(2,4,"pastry");
      bool repeat = true;
      while(repeat)
      {
        Console.WriteLine("Enter 1 (1), if you are a customer and looking to buy.");
        Console.WriteLine("Enter 2 (2), if you are the owner and trying to update the menu.");
        Console.WriteLine("Enter 3 (3), if you want to leave.");
        string choice = Console.ReadLine();
        
        if(choice == "1")
        {
          ShowMenu(pastry);
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

//Add items to menu
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


// Here is showing the menu to the user.

    static void ShowMenu(Pastry pastry)
    {
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("          The Menu");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Dictionary<string,int[]> menuList = Pastry.GetAll();
      int index = 1;
      int totalPrice = 0;
      Console.WriteLine("");
      foreach(KeyValuePair<string,int[]> kvp in menuList)
      {
        int itemCost = pastry.FindDiscountedPrice(kvp.Value[0],kvp.Value[1],kvp.Value[2]);
        totalPrice += itemCost;
        if(kvp.Value[2] > 0){
          Console.WriteLine($"({kvp.Key}): The price for {kvp.Key} is ${kvp.Value[1]} with a discount of buy {kvp.Value[2]} get 1 free : current amount - {kvp.Value[0]} - ${itemCost}");
        } else
        {
          Console.WriteLine($"({kvp.Key}): The price for {kvp.Key} is ${kvp.Value[1]} with no discount : current amount - {kvp.Value[0]}");
        }
        Console.WriteLine($"{kvp.Value[0]}");
        index++;
        
      }

      // user input to find dictionary key
      Console.WriteLine($"\nyour current Total price is ${totalPrice}");
      

      bool correctResponse = false;
      while (!correctResponse)
      {
        Console.Write("Enter (item) or (exit): ");
        string choice = (Console.ReadLine()).ToLower();

        if(menuList.ContainsKey(choice))
        {
          int amount = BuyAmount();
          Console.WriteLine($"amount = {amount}");
          pastry.AddAmountToKey(choice,amount);
          correctResponse = true;
        } else if (choice == "exit")
        {
          correctResponse = true;
        } else 
        {
          Console.WriteLine("Please enter an item in the \"()\" to buy that item. \"()\" not included.");
        }



      }
      
 
// check total price again
      totalPrice = 0;
      foreach(KeyValuePair<string,int[]> kvp in menuList)
      {
        totalPrice += pastry.FindDiscountedPrice(kvp.Value[0],kvp.Value[1],kvp.Value[2]);
      }
      Console.WriteLine($"Your total price is ${totalPrice}");

      Console.WriteLine("Would you like to purchase anything else? (y) (n)");
      string againChoice = Console.ReadLine().ToLower();
      if(againChoice == "y")
      {
        ShowMenu(pastry);
      } else
      {
        Console.WriteLine($"\nThanks for your purchase!\n");
      }
    }
   
   static int BuyAmount()
   {
    Console.WriteLine("\nPlease Enter a number for how many you would like to buy. The discount will automatically be apllied.");
    Console.WriteLine("If you want to go back enter any other character");
    Console.Write("Amount: ");
    int choice;
    try
    {
      choice = int.Parse(Console.ReadLine());
    }
    catch
    {
      choice = 0;
    }
    return choice;
   }
  }
}