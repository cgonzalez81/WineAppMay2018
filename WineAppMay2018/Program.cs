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
			Console.WriteLine("*******************************");
			Console.WriteLine("***********Wine Down***********");

			while (true)
			{
				Console.WriteLine("0. Exit");
				//acct should include address, phone#, email
				Console.WriteLine("1. Create an account");
				Console.WriteLine("2. Orders");
				Console.WriteLine("3. Get the Total");
				Console.WriteLine("4. Enter Payment");
				Console.Write("Order confirmation: ");
				//maybe a line for delivery date
				var option = Console.ReadLine();
				switch (option)
				{
					case "0":
						Console.WriteLine("Thank you and come back again to Wine Down");
						return;
					case "1":
						Console.Write("Email Address: ");
						var emailAddress = Console.ReadLine();

						Console.Write("Order Wine Products: ");
						var orderInventory = Console.ReadLine();

						var inventoryTypes = Enum.GetNames(typeof(InventoryType));
						for (var i = 0; i < inventoryTypes.Length; i++)
						{
							Console.WriteLine($"{i}. {inventoryTypes[i]}");
						}
						Console.Write("Wine Type: ");
						var inventoryType = (InventoryType)Enum.Parse(typeof(InventoryType), Console.ReadLine());

						Console.Write("Initial Deposit: ");
						var amount = Convert.ToDecimal(Console.ReadLine());

						var account = Store.CreateOrder(emailAddress, inventoryType, amount);
						Console.WriteLine($"AN: {account.AccountNumber}, " +
							$"Balance: {account.Balance}, " +
							$"AT: {account.TypeOfAccount}, " +
							$"CD: {account.CreatedDate}");

						break;
					case "2":
						/*Console.Write("Email Address: ");
						var emailAddress = Console.ReadLine();*/

						break;
					case "3":

						break;
					case "4":

						break;
					default:
						break;
				}
			#region Notes
			/*decimal OrderCost;
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
			Console.WriteLine($"EA: {account3.EmailAddress}, : {account3.OrderCost}, OI: {account3.OrderInventory}, DO: {account3.DateOfOrder}");*/
			#endregion


		}
	}
}
