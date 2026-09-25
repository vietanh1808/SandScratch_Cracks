namespace Sigtrap.Relays
{
	public interface IRelayLinkBase<TDelegate> where TDelegate : class
	{
		uint listenerCount { get; }

		uint oneTimeListenersCount { get; }

		bool Contains(TDelegate listener);

		bool AddListener(TDelegate listener, bool allowDuplicates = false);

		IRelayBinding BindListener(TDelegate listener, bool allowDuplicates = false);

		bool AddOnce(TDelegate listener, bool allowDuplicates = false);

		bool RemoveListener(TDelegate listener);

		bool RemoveOnce(TDelegate listener);

		void RemoveAll(bool removePersistentListeners = true, bool removeOneTimeListeners = true);
	}
}
