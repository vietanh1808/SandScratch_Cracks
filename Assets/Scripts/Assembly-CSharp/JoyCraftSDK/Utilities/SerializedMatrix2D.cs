using System;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedMatrix2D<T> : ISerializationCallbackReceiver
	{
		[NonSerialized]
		protected T[,] m_Matrix;

		[SerializeField]
		private int m_MatrixWidth;

		[SerializeField]
		private T[] m_MatrixUnwrapped;

		public int MatrixWidth => 0;

		public int MatrixHeight => 0;

		public T this[int index1, int index2]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public T this[Vector2Int position]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		protected SerializedMatrix2D()
		{
		}

		protected SerializedMatrix2D(int width, int height)
		{
		}

		public bool TryGet(int index1, int index2, out T value)
		{
			value = default;
			return false;
		}

		public bool TryGet(Vector2Int position, out T value)
		{
			value = default;
			return false;
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}
	}
}
