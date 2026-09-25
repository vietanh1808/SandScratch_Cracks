using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	public class TestES3 : JTest
	{
		private const string GROUP_ABSTRACT_CLASS = "Test Abstract Class";

		private const string KEY_ABSTRACT_CLASS = "AbstractClass";

		[SerializeReference]
		private BaseA a;

		protected override string LogName => null;

		protected override void OnTest(ref AEventManager.OnStartTestScene eventData)
		{
		}

		public void SaveAbstractClass()
		{
		}

		public void LoadAbstractClass()
		{
		}

		public void MakeANull()
		{
		}

		private BaseA GetConcreteA()
		{
			return null;
		}
	}
}
