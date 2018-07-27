using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAppMay2018
{
	enum InventoryType
	{
		//Wine types, may include inventory number and descriptions
		Barbera,
		CabernetSauvignon,
		Chardonnay,
		Chianti,
		Gewurtztraminer,
		Malbec,
		Merlot,
		Moscato,
		PinotGrigio,
		PinotNoir,
		Prosecco,
		Riesling,
		Rose,
		SauvignonBlanc,
		Shiraz,
		Syrah,
		Zinfandel,
	}


	class Account
	{

		private static int lastOrderNumber = 0000;
		//app does not need acct number but maybe order number generated
		//private static int lastAccountNumber = 0;
		#region Properties
		/// <summary>
		/// AccountName can be email address
		/// </summary>
		// not gonna use this: public string LoginName { get; set; }
		//public string Password { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string BirthYear { get; set; }
		public string EmailAddress { get; set; }
		/// <summary>
		/// Debit or credit card to use for purchases
		/// </summary>
		public string CardNumber { get; set; }
		//date the account was created, need to figure out just one date for that
		//public DateTime AcctCreationDate { get; set; }
		public DateTime DateOfOrder { get; set; }
		public decimal OrderCost { get; set; }
		//not sure how to do this yet - type of wine maybe with description, giftcards or baskets
		//public string InventoryDescription { get; set; } 
		//number of bottles in inventory to order
		//public int OrderNumber { get; set; }
		public int Inventory { get; set; }
		public InventoryType OrderInventory { get; set; }

		#endregion

		public Account()
		{
			//OrderNumber = ++lastOrderNumber;
			DateOfOrder = DateTime.UtcNow;
		}

		#region Methods

		public int Order(int amount)
		{
			Inventory += amount;
			return Inventory;
		}

		public decimal Price(decimal amount)
		{
			OrderCost += amount;
			return OrderCost;
		}

		#endregion


	}


}
