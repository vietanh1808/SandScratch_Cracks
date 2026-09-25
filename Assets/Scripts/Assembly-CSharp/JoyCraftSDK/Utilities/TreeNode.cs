using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class TreeNode
	{
		public const int INVALID_ID = -1;

		[SerializeField]
		private int m_Id;

		[SerializeField]
		private int m_Parent;

		[SerializeField]
		private List<int> m_Children;

		public int Id => 0;

		public int Parent
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private List<int> Children
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TreeNode(int id, int parent)
		{
		}

		public List<int> GetCopyChildren()
		{
			return null;
		}

		public int GetIndexInChildren(int id)
		{
			return 0;
		}

		public int GetChildrenCount()
		{
			return 0;
		}

		public bool RemoveInChildren(int id)
		{
			return false;
		}

		public void InsertInChildrenAtIndex(int index, int id)
		{
		}
	}
}
