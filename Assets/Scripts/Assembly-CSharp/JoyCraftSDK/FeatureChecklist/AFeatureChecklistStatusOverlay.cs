using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.FeatureChecklist
{
	public abstract class AFeatureChecklistStatusOverlay : JScriptableObject
	{
		[SerializeField]
		private string developer;

		[SerializeField]
		private List<FeatureChecklistStatusEntry> statuses;

		public string Developer => null;

		public List<FeatureChecklistStatusEntry> Statuses => null;
	}
}
