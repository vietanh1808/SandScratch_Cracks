using System;

namespace Sigtrap.Relays
{
	public interface IRelayLink : IRelayLinkBase<Action>
	{
	}
	public interface IRelayLink<T> : IRelayLinkBase<Action<T>>
	{
	}
	public interface IRelayLink<T, U> : IRelayLinkBase<Action<T, U>>
	{
	}
	public interface IRelayLink<T, U, V> : IRelayLinkBase<Action<T, U, V>>
	{
	}
	public interface IRelayLink<T, U, V, W> : IRelayLinkBase<Action<T, U, V, W>>
	{
	}
}
