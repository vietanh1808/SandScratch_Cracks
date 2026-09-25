using System.Text;
using TouchScript.Pointers;
using UnityEngine.UI;

namespace TouchScript.Behaviors.Cursors
{
	public abstract class TextPointerCursor<T> : PointerCursor where T : IPointer
	{
		public bool ShowPointerId;

		public bool ShowFlags;

		public Text Text;

		private static StringBuilder stringBuilder;

		protected override void updateOnce(IPointer pointer)
		{
		}

		protected virtual void generateText(T pointer, StringBuilder str)
		{
		}

		protected virtual bool textIsVisible()
		{
			return false;
		}

		protected virtual uint gethash(T pointer)
		{
			return 0u;
		}

		protected sealed override uint getPointerHash(IPointer pointer)
		{
			return 0u;
		}
	}
}
