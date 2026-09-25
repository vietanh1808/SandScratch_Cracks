using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.IAP
{
	public abstract class AIAPGroupConfig : JScriptableObject
	{
		public abstract IReadOnlyList<string> GetGroupMembers(string productID);
	}
}
