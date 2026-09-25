using System.Collections.Generic;
using UnityEngine.Purchasing;

namespace UniPay
{
	internal class CustomStoreCart : ICart
	{
		private readonly List<CartItem> _items;

		public IReadOnlyList<CartItem> Items()
		{
			return null;
		}

		public CustomStoreCart(Product product, int quantity = 1)
		{
		}
	}
}
