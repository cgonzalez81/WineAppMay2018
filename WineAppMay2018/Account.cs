using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAppMay2018
{
	class Account
	{

		#region Properties
		/// <summary>
		/// AccountName can be email address
		/// </summary>
		public string LoginName { get; set; }
		public string Password { get; set; }
		public int PhoneNumber { get; set; }
		public string LicenseNumber { get; set; }
		public string EmailAddress { get; set; }
		/// <summary>
		/// Debit or credit card to use for purchases
		/// </summary>
		public int CardNumber { get; set; }
		//date the account was created, need to figure out just one date for that
		public DateTime AcctCreationDate { get; set; }
		public DateTime DateOfOrder { get; set; }
		//not sure how to do this yet - type of wine maybe with description, giftcards or baskets
		public string InventoryDescription { get; set; } 
		//number of bottles in inventory to order
		public int Inventory { get; set; }

		#endregion

		#region Methods

		public void Order(int amount)
		{
			Inventory -= amount;

		}

	

		#endregion


	}


}
