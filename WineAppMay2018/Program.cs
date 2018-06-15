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
			decimal OrderCost;
			//refers to account class in account.cs
			var account = Store.CreateOrder("test@test.com", InventoryType.Barbera, 2, OrderCost = 10.05M);
			Console.WriteLine($"EA: { account.EmailAddress}, " +
				$"Inventory: { account.Inventory}, " +
				$"OC: {account.OrderCost}, " +
				$"ON: {account.OrderNumber}, " +
				$"OI: {account.OrderInventory}, " +
				$"DO: {account.DateOfOrder}");
			//OrderCost = "0",


			var account2 = Store.CreateOrder("test2@test.com");
			Console.WriteLine($"EA: {account2.EmailAddress}, : {account2.OrderCost}, OI: {account2.OrderInventory}, DO: {account2.DateOfOrder}");

			var account3 = Store.CreateOrder("test2@test.com");
			Console.WriteLine($"EA: {account3.EmailAddress}, : {account3.OrderCost}, OI: {account3.OrderInventory}, DO: {account3.DateOfOrder}");



		}
	}
}
