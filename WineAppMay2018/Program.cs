using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAppMay2018
{
	class Program
	{
		static void Main(string[] args)
		{
			//refers to account class in account.cs
			var account = new Account
			{
				LoginName = "Jesse123",
				Password = "password1one",
				InventoryDescription = "Malbec",
				//OrderCost = "0",

		};

			Console.WriteLine($"LN: {account.LoginName}, EA: {account.EmailAddress}, ID: {account.InventoryDescription}, OC: {account.OrderCost}");
			
			

		}
	}
}
