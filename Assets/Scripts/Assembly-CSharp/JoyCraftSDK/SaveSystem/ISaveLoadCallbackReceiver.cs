namespace JoyCraftSDK.SaveSystem
{
	public interface ISaveLoadCallbackReceiver
	{
		void BeforeSaving();

		void AfterLoading();
	}
}
