using System;
using System.Collections.Generic;

namespace FirstConsoleProject{

class MainClass 
{
  public static void Main (string[] args) 
	{
		Dictionary<string, int> prices = new(5);
			prices.Add("Watermelon", 5);
			prices.Add("Car", 1000000);
			prices.Add("Sword", 50000);
      
			Console.WriteLine(prices["Watermelon"]); 

			Console.ReadKey();
  }
}
}
