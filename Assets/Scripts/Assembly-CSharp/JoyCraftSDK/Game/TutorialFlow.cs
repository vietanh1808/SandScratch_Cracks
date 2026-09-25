using System.Collections.Generic;
using JoyCraftSDK.SaveSystem;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Events;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "TutorialFlow", menuName = "Tutorial/Flow")]
	public class TutorialFlow : JScriptableObject
	{
		public TutorialType type;

		public int activeInLevel;

		public List<TutorialStep> steps;

		public UnityEvent OnCompleteEvent;

		[Header("Belt Prefill")]
		[SerializeField]
		private GameObjectColor beltFillColor;

		[Range(0f, 1f)]
		[SerializeField]
		private float beltFillRatio;

		[SerializeField]
		private List<ColorJarRowData> extraColorJarRows;

		[SerializeField]
		private List<ConveyorPrefillEntry> conveyorPrefill;

		public GameObjectColor BeltFillColor => GameObjectColor.None;

		public float BeltFillRatio => 0f;

		public List<ColorJarRowData> ExtraColorJarRows => null;

		public List<ConveyorPrefillEntry> ConveyorPrefill => null;

		public bool IsComplete => false;

		public void Load()
		{
		}

		protected internal void SetComplete()
		{
		}

		protected virtual SavedTutorialData GetSavedTutorialData()
		{
			return null;
		}
	}
}
