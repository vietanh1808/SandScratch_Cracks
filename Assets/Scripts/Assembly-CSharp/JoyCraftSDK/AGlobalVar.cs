using System;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK
{
	[Serializable]
	public abstract class AGlobalVar<T> : JScriptableObject
	{
		public Relay<T> OnValueChange;

		public abstract void SetValue(T t);

		public abstract void SetValueWithoutInvokeChange(T t);

		public abstract T GetValue();
	}
}
