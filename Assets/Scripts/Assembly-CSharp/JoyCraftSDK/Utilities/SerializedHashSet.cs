using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedHashSet<T> : ISerializationCallbackReceiver, IEnumerable<T>, IEnumerable
	{
		[NonSerialized]
		private HashSet<T> m_HashSet;

		[SerializeField]
		private T[] m_Values;

		public int Count => 0;

		public bool Contains(T value)
		{
			return false;
		}

		public void Clear()
		{
		}

		public bool Add(T value)
		{
			return false;
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
