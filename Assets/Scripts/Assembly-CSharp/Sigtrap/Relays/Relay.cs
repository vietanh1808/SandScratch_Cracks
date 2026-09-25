using System;

namespace Sigtrap.Relays
{
	public class Relay : RelayBase<Action>, IRelayLink, IRelayLinkBase<Action>
	{
		private IRelayLink _link;

		public IRelayLink link => null;

		public void Dispatch()
		{
		}
	}
	public class Relay<T> : RelayBase<Action<T>>, IRelayLink<T>, IRelayLinkBase<Action<T>>
	{
		private IRelayLink<T> _link;

		public IRelayLink<T> link => null;

		public void Dispatch(T t)
		{
		}
	}
	public class Relay<T, U> : RelayBase<Action<T, U>>, IRelayLink<T, U>, IRelayLinkBase<Action<T, U>>
	{
		private IRelayLink<T, U> _link;

		public IRelayLink<T, U> link => null;

		public void Dispatch(T t, U u)
		{
		}
	}
	public class Relay<T, U, V> : RelayBase<Action<T, U, V>>, IRelayLink<T, U, V>, IRelayLinkBase<Action<T, U, V>>
	{
		private IRelayLink<T, U, V> _link;

		public IRelayLink<T, U, V> link => null;

		public void Dispatch(T t, U u, V v)
		{
		}
	}
	public class Relay<T, U, V, W> : RelayBase<Action<T, U, V, W>>, IRelayLink<T, U, V, W>, IRelayLinkBase<Action<T, U, V, W>>
	{
		private IRelayLink<T, U, V, W> _link;

		public IRelayLink<T, U, V, W> link => null;

		public void Dispatch(T t, U u, V v, W w)
		{
		}
	}
}
