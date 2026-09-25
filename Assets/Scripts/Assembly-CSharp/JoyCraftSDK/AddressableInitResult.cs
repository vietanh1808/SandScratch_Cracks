namespace JoyCraftSDK
{
	public readonly struct AddressableInitResult
	{
		public bool AddressablesInitialized { get; }

		public bool TimedOut { get; }

		public bool DictValid { get; }

		public AddressableInitResult(bool addressablesInitialized, bool timedOut, bool dictValid)
		{
			AddressablesInitialized = false;
			TimedOut = false;
			DictValid = false;
		}
	}
}
