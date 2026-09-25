using System.Collections.Generic;
using UnityEngine.Events;

namespace TouchScript.Utils
{
	public class ObjectPool<T> where T : class
	{
		public delegate T0 UnityFunc<T0>();

		private readonly Stack<T> stack;

		private readonly UnityAction<T> onGet;

		private readonly UnityAction<T> onRelease;

		private readonly UnityFunc<T> onNew;

		public string Name { get; set; }

		public int CountAll { get; private set; }

		public int CountActive => 0;

		public int CountInactive => 0;

		public ObjectPool(int capacity, UnityFunc<T> actionNew, UnityAction<T> actionOnGet = null, UnityAction<T> actionOnRelease = null, string name = null)
		{
		}

		public void WarmUp(int count)
		{
		}

		public T Get()
		{
			return null;
		}

		public void Release(T element)
		{
		}

		public void Release(object element)
		{
		}
	}
}
