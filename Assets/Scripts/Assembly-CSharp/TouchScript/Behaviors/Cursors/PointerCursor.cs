using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_PointerCursor.htm")]
	public class PointerCursor : MonoBehaviour
	{
		public enum CursorState
		{
			Released = 0,
			Pressed = 1,
			Over = 2,
			OverPressed = 3
		}

		protected CursorState state;

		protected object stateData;

		protected RectTransform rect;

		protected float size;

		protected float defaultSize;

		protected uint hash;

		public float Size
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Init(RectTransform parent, IPointer pointer)
		{
		}

		public void UpdatePointer(IPointer pointer)
		{
		}

		public void SetState(IPointer pointer, CursorState newState, object data = null)
		{
		}

		public void Hide()
		{
		}

		public virtual void Awake()
		{
		}

		protected virtual void hide()
		{
		}

		protected virtual void show()
		{
		}

		protected virtual void updateOnce(IPointer pointer)
		{
		}

		protected virtual void update(IPointer pointer)
		{
		}

		protected virtual uint getPointerHash(IPointer pointer)
		{
			return 0u;
		}
	}
}
