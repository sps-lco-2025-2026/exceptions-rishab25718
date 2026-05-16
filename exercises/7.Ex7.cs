using System;
using System.Collections.Generic;


//Main code

Dictionary<string, int> inventory = new Dictionary<string, int>
{
    { "sword", 1 },
    { "potion", 5 },
    { "shield", 2 }
};

Console.WriteLine("Enter prompts of the form 'take sword' asking to take amounts of certain items, if you want to stop, type exit");

bool valid = true;

while (valid == true)
{
    string input = string.Parse(Console.ReadLine);

    if (input == "exit")
    {
        valid = false;
        break;
    }

    string item = input[1];

    try
    {
        if (inventory.ContainsKey(item) == false)
        {
            throw ItemNotFoundException(item);
        }

        if (inventory[item] < 0)
        {
            throw InsufficientQuantityException(item, 0, 1);
        }

        inventory[item] = inventory[item] - 1;

        Console.WriteLine($"You took 1 {item} Remaning: {inventory[item]}");
    }

    catch (ItemNotFoundException e)
    {
        Console.WriteLine($"Error - {e.Message}");
    }

    catch (InsufficientQuantityException e)
    {
        Console.WriteLine($"Error - {e.Message}");
    }

    catch (InventoryException e)
    {
        Console.WriteLine($"Unknown general error type {e.Message}");
    }
}

//Exception Classes

class InventoryException : Exception
{
    public InventoryException();

    public InventoryException(string message)
        : base(message);

    public InventoryException(string message, Exception inner)
        : base(message, inner);
}

class ItemNotFoundException : InventoryException
{
    public string ItemName { get;}

    public ItemNotFoundException(string itemName)
    {
        Console.WriteLine($"The item {itemName} was not found");

        ItemName = itemName;
    }
}

class InsufficientQuantityException : InventoryException
{
    public string ItemName { get;}
    public int Available { get;}
    public int Required { get;}

    public InsufficientQuantityException(string itemName, int available, int required)
    {
        Console.WriteLine($"You asked for {required} of {itemName} but you only have {available} available");
        ItemName = itemName;
        Available = available;
        Required = required;
    }
}








