using System;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class AAuthenticationManager : JBase
	{
		public abstract void Init(Action onComplete = null);
	}
}
