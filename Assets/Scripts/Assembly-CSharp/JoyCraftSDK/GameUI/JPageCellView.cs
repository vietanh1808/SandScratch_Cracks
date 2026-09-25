using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.GameUI
{
	public class JPageCellView : JCellView
	{
		private JPageEnterAnim _enterAnim;

		public virtual float CellSize => 0f;

		public override void Awake()
		{
		}

		public virtual void OnPageEnter(bool animate)
		{
		}

		public virtual void OnPageExit()
		{
		}
	}
}
