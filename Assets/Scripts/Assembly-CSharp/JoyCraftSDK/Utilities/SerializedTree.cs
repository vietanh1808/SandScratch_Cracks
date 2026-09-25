using System;
using System.Collections.Generic;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public abstract class SerializedTree<TValue> where TValue : class
	{
		public const int NODE_INVALID = -1;

		[SerializeField]
		internal int m_Dirty;

		[SerializeField]
		protected TreeData<TValue> m_Data;

		[SerializeField]
		protected TreeNodes m_Nodes;

		[SerializeField]
		protected List<int> m_Roots;

		public Relay EventChange;

		public int[] RootIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int FirstRootId => 0;

		public TreeNodes Nodes => null;

		public int Count => 0;

		public SerializedTree()
		{
		}

		public bool Contains(int id)
		{
			return false;
		}

		public TValue Get(int id)
		{
			return null;
		}

		public int Parent(int id)
		{
			return 0;
		}

		public int SiblingIndex(int id)
		{
			return 0;
		}

		public int PreviousSibling(int id)
		{
			return 0;
		}

		public int NextSibling(int id)
		{
			return 0;
		}

		public List<int> Children(int id)
		{
			return null;
		}

		public List<int> Siblings(int id)
		{
			return null;
		}

		public int FindNodeId(Predicate<TValue> predicate)
		{
			return 0;
		}

		public List<int> FindAllNodeIds(Predicate<TValue> predicate)
		{
			return null;
		}

		public List<int> GetConnectedNodeIds(int nodeId)
		{
			return null;
		}

		public List<TValue> GetConnectedValues(int nodeId)
		{
			return null;
		}

		public virtual int AddRootNode(TValue node)
		{
			return 0;
		}

		public virtual int AddRootNode(TValue node, int index)
		{
			return 0;
		}

		public virtual int AddChild(TValue value, int parent)
		{
			return 0;
		}

		public virtual int AddChild(TValue value, int parent, int index)
		{
			return 0;
		}

		public virtual int AddBeforeSibling(TValue value, int sibling)
		{
			return 0;
		}

		public virtual int AddAfterSibling(TValue value, int sibling)
		{
			return 0;
		}

		public virtual bool Remove(int node)
		{
			return false;
		}

		public virtual void Clear()
		{
		}

		private int NewId()
		{
			return 0;
		}

		private int Add(TValue value, int parent, int index)
		{
			return 0;
		}

		public List<int> TraversePreorder(int startNodeId = -1)
		{
			return null;
		}

		private void TraversePreorderRecursive(int nodeId, List<int> result)
		{
		}

		public List<int> TraverseInorder(int startNodeId = -1)
		{
			return null;
		}

		private void TraverseInorderRecursive(int nodeId, List<int> result)
		{
		}

		public List<int> TraversePostorder(int startNodeId = -1)
		{
			return null;
		}

		private void TraversePostorderRecursive(int nodeId, List<int> result)
		{
		}

		public List<int> TraverseLevelOrder(int startNodeId = -1)
		{
			return null;
		}

		public List<int> GetNodesAtDepth(int depth, int startNodeId = -1)
		{
			return null;
		}

		private void GetNodesAtDepthRecursive(int nodeId, int currentDepth, int targetDepth, List<int> result)
		{
		}

		public int GetDepth(int startNodeId = -1)
		{
			return 0;
		}

		private int GetDepthRecursive(int nodeId)
		{
			return 0;
		}

		public int GetNodeDepth(int nodeId)
		{
			return 0;
		}
	}
}
