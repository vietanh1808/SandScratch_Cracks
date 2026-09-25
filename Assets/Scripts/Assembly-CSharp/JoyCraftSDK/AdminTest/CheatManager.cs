namespace JoyCraftSDK.AdminTest
{
	public class CheatManager : ACheatManager
	{
		private CheatData _cheatData;

		public override CheatData CheatData
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		private void OnUpdate(ref AEventManager.OnUpdate evt)
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
