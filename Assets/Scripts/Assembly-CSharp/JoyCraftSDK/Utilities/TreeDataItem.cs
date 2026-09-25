using System;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class TreeDataItem<T> where T : class
	{
		[SerializeField]
		private int m_Id;

		[SerializeReference]
		private T m_Value;

		public int Id => 0;

		public T Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TreeDataItem(int nodeId, T value)
		{
		}
	}
}
