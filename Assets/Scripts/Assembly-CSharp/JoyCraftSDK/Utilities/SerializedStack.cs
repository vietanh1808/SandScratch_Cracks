using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedStack<T> : Stack<T>, ISerializationCallbackReceiver
	{
		[SerializeField]
		[HideInInspector]
		public List<T> values;

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public void MakeElementToTopStack(T element)
		{
		}
	}
}
