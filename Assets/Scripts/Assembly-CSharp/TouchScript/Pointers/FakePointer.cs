using TouchScript.Hit;
using TouchScript.InputSources;
using UnityEngine;

namespace TouchScript.Pointers
{
	public class FakePointer : IPointer
	{
		public int Id { get; private set; }

		public Pointer.PointerType Type { get; private set; }

		public IInputSource InputSource { get; private set; }

		public Vector2 Position { get; set; }

		public uint Flags { get; private set; }

		public Pointer.PointerButtonState Buttons { get; private set; }

		public Vector2 PreviousPosition { get; private set; }

		public FakePointer(Vector2 position)
		{
		}

		public FakePointer()
		{
		}

		public HitData GetOverData(bool forceRecalculate = false)
		{
			return default;
		}
	}
}
