using System;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	[Serializable]
	[CreateAssetMenu(fileName = "TestIntVar", menuName = "JoyCraft/Quests/TestVars/TestIntVar")]
	public class TestIntVar : AGlobalVar<int>
	{
		[SerializeField]
		private int value;

		public Relay<int> OnValueChangeEvent => null;

		public override void SetValue(int t)
		{
		}

		public override void SetValueWithoutInvokeChange(int t)
		{
		}

		public override int GetValue()
		{
			return 0;
		}

		public bool GreaterThanOrEqualTo(int value)
		{
			return false;
		}
	}
}
