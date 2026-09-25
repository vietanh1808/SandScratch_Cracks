namespace Sigtrap.Relays.Binding
{
	public class RelayBinding<TDelegate> : IRelayBinding where TDelegate : class
	{
		protected IRelayLinkBase<TDelegate> _relay { get; private set; }

		protected TDelegate _listener { get; private set; }

		public bool enabled { get; private set; }

		public bool allowDuplicates { get; set; }

		public uint listenerCount => 0u;

		private RelayBinding()
		{
		}

		public RelayBinding(IRelayLinkBase<TDelegate> relay, TDelegate listener, bool allowDuplicates, bool isListening)
		{
		}

		public bool Enable(bool enable)
		{
			return false;
		}
	}
}
