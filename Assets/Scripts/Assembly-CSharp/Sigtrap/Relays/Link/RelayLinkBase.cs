namespace Sigtrap.Relays.Link
{
	public abstract class RelayLinkBase<TDelegate> : IRelayLinkBase<TDelegate> where TDelegate : class
	{
		protected RelayBase<TDelegate> _relay;

		public uint listenerCount => 0u;

		public uint oneTimeListenersCount => 0u;

		private RelayLinkBase()
		{
		}

		public RelayLinkBase(RelayBase<TDelegate> relay)
		{
		}

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
	}
}
