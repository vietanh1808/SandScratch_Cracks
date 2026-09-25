using System;

namespace Sigtrap.Relays
{
	public abstract class RelayBase<TDelegate> : IRelayLinkBase<TDelegate> where TDelegate : class
	{
		protected bool _hasLink;

		protected TDelegate[] _listeners;

		protected uint _count;

		protected uint _cap;

		protected TDelegate[] _listenersOnce;

		protected uint _onceCount;

		protected uint _onceCap;

		protected static IndexOutOfRangeException _eIOOR;

		public uint listenerCount => 0u;

		public uint oneTimeListenersCount => 0u;

		public bool Contains(TDelegate listener)
		{
			return false;
		}

		public bool AddListener(TDelegate listener, bool allowDuplicates = false)
		{
			return false;
		}

		public IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false)
		{
			return null;
		}

		public bool AddOnce(TDelegate listener, bool allowDuplicates = false)
		{
			return false;
		}

		public bool RemoveListener(TDelegate listener)
		{
			return false;
		}

		public bool RemoveOnce(TDelegate listener)
		{
			return false;
		}

		public void RemoveAll(bool removePersistentListeners = true, bool removeOneTimeListeners = true)
		{
		}

		protected void RemoveAt(uint i)
		{
		}

		protected void RemoveOnceAt(uint i)
		{
		}

		protected uint RemoveAt(TDelegate[] arr, uint count, uint i)
		{
			return 0u;
		}

		private bool Contains(TDelegate[] arr, uint c, TDelegate d)
		{
			return false;
		}

		private TDelegate[] Expand(TDelegate[] arr, uint cap, uint count)
		{
			return null;
		}
	}
}
