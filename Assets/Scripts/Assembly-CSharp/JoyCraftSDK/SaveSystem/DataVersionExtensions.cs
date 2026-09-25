namespace JoyCraftSDK.SaveSystem
{
	public static class DataVersionExtensions
	{
		public static void UpdateDataVersion<T>(T obj) where T : ISavableData
		{
		}

		public static void SealToMaxVersion<T>(T obj) where T : ISavableData
		{
		}

		private static void UpdateSubData<T>(T obj) where T : ISavableData
		{
		}

		public static string GetUpdateSuccessMessage(string className, int oldVersion)
		{
			return null;
		}

		public static string GetUpdateFailureMessage(string className, int oldVersion)
		{
			return null;
		}
	}
}
