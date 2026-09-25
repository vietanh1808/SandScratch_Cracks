using System;

namespace Sigtrap.Relays.Link
{
	public class RelayLink : RelayLinkBase<Action>, IRelayLink, IRelayLinkBase<Action>
	{
		public RelayLink(RelayBase<Action> relay)
			: base((RelayBase<Action>)null)
		{
		}
	}
	public class RelayLink<T> : RelayLinkBase<Action<T>>, IRelayLink<T>, IRelayLinkBase<Action<T>>
	{
		public RelayLink(RelayBase<Action<T>> relay)
			: base((RelayBase<Action<T>>)null)
		{
		}
	}
	public class RelayLink<T, U> : RelayLinkBase<Action<T, U>>, IRelayLink<T, U>, IRelayLinkBase<Action<T, U>>
	{
		public RelayLink(RelayBase<Action<T, U>> relay)
			: base((RelayBase<Action<T, U>>)null)
		{
		}
	}
	public class RelayLink<T, U, V> : RelayLinkBase<Action<T, U, V>>, IRelayLink<T, U, V>, IRelayLinkBase<Action<T, U, V>>
	{
		public RelayLink(RelayBase<Action<T, U, V>> relay)
			: base((RelayBase<Action<T, U, V>>)null)
		{
		}
	}
	public class RelayLink<T, U, V, W> : RelayLinkBase<Action<T, U, V, W>>, IRelayLink<T, U, V, W>, IRelayLinkBase<Action<T, U, V, W>>
	{
		public RelayLink(RelayBase<Action<T, U, V, W>> relay)
			: base((RelayBase<Action<T, U, V, W>>)null)
		{
		}
	}
}
