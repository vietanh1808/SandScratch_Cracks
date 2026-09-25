using System;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class TreeData<TValue> : SerializedDictionary<int, TreeDataItem<TValue>> where TValue : class
	{
	}
}
