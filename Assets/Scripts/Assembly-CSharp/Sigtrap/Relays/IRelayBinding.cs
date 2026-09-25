namespace Sigtrap.Relays
{
	public interface IRelayBinding
	{
		bool enabled { get; }

		bool allowDuplicates { get; set; }

		uint listenerCount { get; }

		bool Enable(bool enable);
	}
}
