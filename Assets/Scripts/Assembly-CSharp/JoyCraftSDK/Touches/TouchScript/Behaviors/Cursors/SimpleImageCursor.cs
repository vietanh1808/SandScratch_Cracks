using TouchScript.Behaviors.Cursors;
using TouchScript.Pointers;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.Touches.TouchScript.Behaviors.Cursors
{
	public class SimpleImageCursor : PointerCursor
	{
		[SerializeField]
		public Image CursorImage;

		private bool isTouching;

		public override void Awake()
		{
		}

		protected override void updateOnce(IPointer pointer)
		{
		}

		private bool IsPointerActive(IPointer pointer)
		{
			return false;
		}

		private void UpdateVisualState()
		{
		}

		protected override uint getPointerHash(IPointer pointer)
		{
			return 0u;
		}

		protected override void hide()
		{
		}

		protected override void show()
		{
		}

		public bool IsShowing()
		{
			return false;
		}
	}
}
