namespace JoyCraftSDK.GameUI
{
	public class UILayerManagerFlow : AUILayerManager
	{
		public override AUIPanel ShowPanel(UIPanelID panelID, AUIPanel prefab)
		{
			return null;
		}

		public void ReappearTop()
		{
		}

		private void DeactivateAllExcept(AUIPanel except)
		{
		}
	}
}
