namespace JoyCraftSDK.SaveSystem
{
	public interface IDataVersion
	{
		int GetMaxVersion();

		int GetCurrentVersion();

		void SetCurrentVersion(int version);

		void UpdateVersion();

		bool UpdateVersionIncremental(int currentVersion);
	}
}
