using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAppMay2018
{
	static class Store
	
	{
		private static List<Account> accounts = new List<Account>();
		public static Account CreateOrder(string emailAddress, 
			string address,
			string phoneNumber,
			string birthYear,
			int inventory,
			string cardNumber,
			InventoryType orderInventory=InventoryType.Barbera,
			int initialOrder =0,
			decimal orderCost = 10)

		{
			var order = new Account
			{
				EmailAddress = emailAddress,
				OrderInventory = orderInventory,
				OrderCost = orderCost,
				BirthYear = birthYear,
				Address = address,
				PhoneNumber = phoneNumber,
				Inventory = inventory,
				CardNumber = cardNumber

			};
			if (initialOrder > 0)
			{
				order.Order(initialOrder);
			}

			
			return order;
		
		}

		public static IEnumerable<Account>
			GetAllAccountsByEmailAddress(string emailAddress)

		{
			return accounts.Where(a => a.EmailAddress == emailAddress);
		}

		public static void Deposit(int accountNumber, decimal amount)

		{
			accounts.Where(a => a.AccountNumber == accountNumber)
		}

	}
}
