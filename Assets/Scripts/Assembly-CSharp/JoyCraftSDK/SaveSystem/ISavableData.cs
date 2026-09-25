using System.Collections.Generic;

namespace JoyCraftSDK.SaveSystem
{
	public interface ISavableData : IDataVersion, ISaveLoadCallbackReceiver
	{
		List<ISavableData> GetChildrenISavableData();

		bool IsValid();
	}
}
