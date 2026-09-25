using TouchScript.Hit;
using TouchScript.InputSources;
using UnityEngine;

namespace TouchScript.Pointers
{
	public interface IPointer
	{
		int Id { get; }

		Pointer.PointerType Type { get; }

		Pointer.PointerButtonState Buttons { get; }

		IInputSource InputSource { get; }

		Vector2 Position { get; set; }

		Vector2 PreviousPosition { get; }

		uint Flags { get; }

		HitData GetOverData(bool forceRecalculate = false);
	}
}
