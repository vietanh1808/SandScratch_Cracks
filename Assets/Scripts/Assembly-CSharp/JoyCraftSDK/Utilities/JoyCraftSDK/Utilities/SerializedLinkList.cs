using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities.JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedLinkList<T> : ISerializationCallbackReceiver, IEnumerable<T>, IEnumerable
	{
		[NonSerialized]
		private LinkedList<T> m_LinkList;

		[SerializeField]
		private T[] m_Values;

		public int Count => 0;

		public bool IsEmpty => false;

		public bool Contains(T value)
		{
			return false;
		}

		public void Clear()
		{
		}

		public T First()
		{
			return default;
		}

		public T Last()
		{
			return default;
		}

		public void AddFirst(T value)
		{
		}

		public void AddLast(T value)
		{
		}

		public T RemoveFirst()
		{
			return default;
		}

		public T RemoveLast()
		{
			return default;
		}

		public bool Remove(T value)
		{
			return false;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
