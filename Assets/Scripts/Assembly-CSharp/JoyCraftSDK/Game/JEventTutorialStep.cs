using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	public abstract class JEventTutorialStep : JMonoBehaviour, IStepEvent
	{
		public UnityEvent OnCompleteEvent;

		public TutorialStep StepData { get; set; }

		public Vector3 GetCanvasPos(Vector3 worldPos)
		{
			return default;
		}
	}
}
