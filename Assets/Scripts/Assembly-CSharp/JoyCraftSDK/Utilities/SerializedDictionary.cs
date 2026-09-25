using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, ISerializationCallbackReceiver
	{
		[NonSerialized]
		protected Dictionary<TKey, TValue> m_Dictionary;

		[FormerlySerializedAs("keyData")]
		[SerializeField]
		private TKey[] m_Keys;

		[FormerlySerializedAs("valueData")]
		[SerializeField]
		private TValue[] m_Values;

		public int Count => 0;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		public TValue this[TKey key]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public void Clear()
		{
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			return default;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		protected virtual void BeforeSerialize()
		{
		}

		protected virtual void AfterSerialize()
		{
		}
	}
}
