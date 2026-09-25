using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	public class JTutorialHighlightStep : JMonoBehaviour, IStepEvent, IStep
	{
		[SerializeField]
		private UnityEvent OnStart;

		[SerializeField]
		private UnityEvent OnComplete;

		[SerializeField]
		private JButton highlightedButton;

		public bool IsComplete { get; set; }

		public TutorialStep StepData { get; set; }

		private void Start()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		public void Next()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
