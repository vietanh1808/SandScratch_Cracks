using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TutorialStep", menuName = "Tutorial/Step")]
	public class TutorialStep : JScriptableObject
	{
		[Header("Info")]
		public string stepId;

		public GameObject prefab;

		[TextArea]
		public string description;

		[Header("On Enter")]
		public bool clearPreviousHighlights;

		public List<string> highlightTargetIds;

		[Tooltip("If set, step completes only when this exact target is in the payload of the event.")]
		public string expectedTargetId;

		public bool requireExpectedTargetMatch;

		[Header("Auto-advance")]
		public bool autoCompleteOnEnter;
	}
}
