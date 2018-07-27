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
				//what kinds
				Console.WriteLine("2. Order wine");
				//the number of the kind of wine ordered
				Console.WriteLine("3. Number of bottles selected");
				//needs something that asks for address, age, and PN
				Console.WriteLine("4. Get the Total");
				Console.WriteLine("5. Enter Payment");
				Console.WriteLine("6. See all orders: ");
				Console.Write("Please select an option: ");
				//maybe a line for delivery date
				var option = Console.ReadLine();
				switch (option)
				{
					case "0":
						Console.WriteLine("Thank you and visit us again to Wine Down");
						return;
					case "1":
						Console.Write("Phone Number: ");
						var phoneNumber = Console.ReadLine();

						var inventoryTypes = Enum.GetNames(typeof(InventoryType));
						for (var i = 0; i < inventoryTypes.Length; i++)
						{
							Console.WriteLine($"{i}. {inventoryTypes[i]}");
						}
						Console.Write("Wine Type: ");
						var inventoryType = (InventoryType)Enum.Parse(typeof(InventoryType), Console.ReadLine());

						Console.Write("Enter your full address: ");
						var address = Convert.ToString(Console.ReadLine());

						Console.Write("Year of birth: ");
						var birthYear = Convert.ToString(Console.ReadLine());

						var account = Store.CreateOrder(phoneNumber, address, birthYear, inventoryType, orderCost);
						Console.WriteLine($"PN: {account.PhoneNumber}, " +
							$"Order: {account.OrderInventory}, " +
							$"OC: {account.OrderCost}, " +
							$"CD: {account.DateOfOrder}");

						break;
					case "2":
						//order wine type here
						PrintAllOrders();
						//Console.Write("Phone Number: ");
						//var phoneNumber = Convert.ToInt32(Console.ReadLine());

						Console.Write("Order Description: ");
						orderInventory = Convert.ToString(Console.ReadLine());

						//Store.CreateOrder(phoneNumber, orderCost);
						//Console.WriteLine("Order completed successfully");

						break;
					case "3":
						//number of bottles selected
						PrintAllOrders();
						Console.Write("How many bottles: ");
						int inventory = int.Parse(Console.ReadLine());



						break;
					case "4":
						//get the total
						PrintAllOrders();
						Console.Write("Your total is: ");
						//Store.CreateOrder(orderCost, inventory);
						var total = orderCost * inventory;
						total = Convert.ToDecimal(Console.ReadLine());


						break;
					case "5":
						//enter payment
						PrintAllOrders();

						break;
					case "6":

						PrintAllOrders();

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



			private static void PrintAllOrders()
				Console.Write("Phone Number: ");
			var phoneNumber = Console.ReadLine();

			var accounts = Store.GetAllOrdersByPhoneNumber(phoneNumber);
			foreach (var acct in accounts)
			{
				Console.WriteLine($"EA: {acct.EmailAddress}, " +
				$"Balance: {acct.Balance}, " +
				$"AT: {acct.TypeOfAccount}, " +
				$"CD: {acct.CreatedDate}");
			}

		}
}
