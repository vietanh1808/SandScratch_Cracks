namespace JoyCraftSDK.SaveSystem
{
	public interface ISavableReference
	{
		string GetSaveID();

		void SetIncludedInDictionary(bool included);
	}
}
