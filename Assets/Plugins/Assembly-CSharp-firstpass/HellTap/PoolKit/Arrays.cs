namespace HellTap.PoolKit
{
	public static class Arrays
	{
		public static bool AddItem<T>(ref T[] _arr, T item)
		{
			return false;
		}

		public static void AddItemFastest<T>(ref T[] _arr, T item)
		{
		}

		public static bool AddItemIfNotPresent<T>(ref T[] _arr, T item)
		{
			return false;
		}

		public static bool RemoveItem<T>(ref T[] _arr, ref T item, bool onlyRemoveFirstInstance = false)
		{
			return false;
		}

		public static bool RemoveFirstItem<T>(ref T[] _arr)
		{
			return false;
		}

		public static bool RemoveItemAtIndex<T>(ref T[] _arr, int index)
		{
			return false;
		}

		public static int ItemExistsAtIndex<T>(ref T[] _arr, ref T item)
		{
			return 0;
		}

		public static bool ItemExists<T>(T[] _arr, T item)
		{
			return false;
		}

		public static T[] Concat<T>(this T[] a, T[] b)
		{
			return null;
		}

		public static T[] Combine<T>(T[] a, T[] b)
		{
			return null;
		}

		public static bool Clear<T>(ref T[] arr)
		{
			return false;
		}

		public static bool Shift<T>(ref T[] _arr, int id, bool moveUp)
		{
			return false;
		}
	}
}
