using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	public abstract class AFeatureChecklistData : JScriptableObject
	{
		[SerializeField]
		private ChecklistSource source;

		[SerializeField]
		private List<FeatureChecklistEntry> entries;

		public ChecklistSource Source => ChecklistSource.Sdk;

		public List<FeatureChecklistEntry> Entries => null;
	}
}
