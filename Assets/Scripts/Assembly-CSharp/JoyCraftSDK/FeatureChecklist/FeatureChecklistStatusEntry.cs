using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	[Serializable]
	public class FeatureChecklistStatusEntry : JBase
	{
		[SerializeField]
		private string entryId;

		[SerializeField]
		private TestStatus status;

		public string EntryId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TestStatus Status
		{
			get
			{
				return TestStatus.NotDone;
			}
			set
			{
			}
		}
	}
}
