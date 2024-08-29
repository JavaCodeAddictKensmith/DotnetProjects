using System;
using System.Collections.Generic;

class Geeks
{

    // Main Method 
    public static void Main(String[] args)
    {
        Console.WriteLine("ddjdnjndj======");


        // Creating a List of integers 
        List<int> mylist = new List<int>();

        // adding items in mylist 
        for (int j = 5; j < 10; j++)
        {
            mylist.Add(j * 3);
        }

        // Displaying items of mylist 
        // by using foreach loop 
        foreach (int items in mylist)
        {
            Console.WriteLine(items);
        }
    }
}