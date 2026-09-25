using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class JArrowMenu<T> : AArrowMenu<T>
	{
		private const string Group_Config = "Config";

		private const string Group_Refs = "References";

		[Tooltip("List of options to navigate through")]
		[SerializeField]
		protected List<T> options;

		[Tooltip("Current index in the options list")]
		[SerializeField]
		protected int currentIndex;

		[Tooltip("Whether to wrap around when reaching the list boundaries")]
		[SerializeField]
		protected bool wrapAround;

		[SerializeField]
		protected ABtnEvents leftArrow;

		[SerializeField]
		protected ABtnEvents rightArrow;

		[SerializeField]
		protected TextMeshProUGUI textValue;

		public override T CurrentOption => default;

		protected virtual void Start()
		{
		}

		public override void Init()
		{
		}

		public override void SelectPrevious()
		{
		}

		public override void SelectNext()
		{
		}

		public override void SetOptions(List<T> newOptions)
		{
		}

		public override void SetIndex(int index)
		{
		}

		public override void SetIndexSilent(int index)
		{
		}

		public bool SelectOption(T option, bool silent = false)
		{
			return false;
		}

		private void ValidateIndex()
		{
		}

		private void SetText()
		{
		}

		public int GetCurrentIndex()
		{
			return 0;
		}

		public List<T> GetOptions()
		{
			return null;
		}

		public int GetOptionCount()
		{
			return 0;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
