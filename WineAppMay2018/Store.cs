﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineAppMay2018
{
	static class Store
	
	{
		public static Account CreateOrder(string emailAddress, 
			InventoryType orderInventory=InventoryType.Barbera,
			int initialOrder =0,
			decimal orderCost = 0)
		{
			var order = new Account
			{
				EmailAddress = emailAddress,
				OrderInventory = orderInventory,
				OrderCost = orderCost

			};
			if (initialOrder > 0)
			{
				order.Order(initialOrder);
			}
			return order;
		
		}

	}
}