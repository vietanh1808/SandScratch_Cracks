using TouchScript.Gestures;
using TouchScript.Gestures.TransformGestures;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Examples.Checkers
{
	public class Exclusive : MonoBehaviour, IGestureDelegate
	{
		public TransformGesture Target;

		public Color Color;

		private bool exclusive;

		private Renderer cachedRenderer;

		private float shininess;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public bool ShouldBegin(Gesture gesture)
		{
			return false;
		}

		public bool ShouldReceivePointer(Gesture gesture, Pointer pointer)
		{
			return false;
		}

		public bool ShouldRecognizeSimultaneously(Gesture first, Gesture second)
		{
			return false;
		}
	}
}
