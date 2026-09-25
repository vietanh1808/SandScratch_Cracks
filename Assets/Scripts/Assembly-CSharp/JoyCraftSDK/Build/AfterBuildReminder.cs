using System;

namespace JoyCraftSDK.Build
{
	[Serializable]
	public class AfterBuildReminder
	{
		public string message;

		public bool aabOnly;

		public AfterBuildReminder()
		{
		}

		public AfterBuildReminder(string message, bool aabOnly)
		{
		}
	}
}
