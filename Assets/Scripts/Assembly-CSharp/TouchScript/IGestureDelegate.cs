using TouchScript.Gestures;
using TouchScript.Pointers;

namespace TouchScript
{
	public interface IGestureDelegate
	{
		bool ShouldReceivePointer(Gesture gesture, Pointer pointer);

		bool ShouldBegin(Gesture gesture);

		bool ShouldRecognizeSimultaneously(Gesture first, Gesture second);
	}
}
