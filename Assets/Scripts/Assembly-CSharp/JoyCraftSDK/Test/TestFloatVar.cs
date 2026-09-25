using System;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	[Serializable]
	[CreateAssetMenu(fileName = "TestFloatVar", menuName = "JoyCraft/Quests/TestVars/TestFloatVar")]
	public class TestFloatVar : AGlobalVar<float>
	{
		[SerializeField]
		private float value;

		public Relay<float> OnValueChangeEvent => null;

		public override void SetValue(float t)
		{
		}

		public override void SetValueWithoutInvokeChange(float t)
		{
		}

		public override float GetValue()
		{
			return 0f;
		}

		public bool GreaterThanOrEqualTo(float value)
		{
			return false;
		}
	}
}
