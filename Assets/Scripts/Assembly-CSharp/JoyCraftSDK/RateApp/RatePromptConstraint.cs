using System;
using UnityEngine;

namespace JoyCraftSDK.RateApp
{
	[Serializable]
	public class RatePromptConstraint
	{
		[Tooltip("Số win (kể từ lần hỏi trước) tối thiểu trước khi được phép hiện prompt.")]
		[SerializeField]
		private int minWins;

		[Tooltip("Số GIỜ tối thiểu kể từ lần hỏi trước. Lần đầu (chưa hỏi) coi như đã đủ.")]
		[SerializeField]
		private float minHours;

		public int MinWins => 0;

		public float MinHours => 0f;

		public RatePromptConstraint()
		{
		}

		public RatePromptConstraint(int minWins, float minHours)
		{
		}
	}
}
