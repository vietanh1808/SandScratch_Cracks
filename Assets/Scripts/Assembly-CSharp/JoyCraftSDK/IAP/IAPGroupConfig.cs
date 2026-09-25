using System;
using System.Collections.Generic;
using UnityEngine;

namespace JoyCraftSDK.IAP
{
	[Serializable]
	[CreateAssetMenu(fileName = "IAPGroupConfig", menuName = "JoyCraft/Configs/IAPGroupConfig")]
	public class IAPGroupConfig : AIAPGroupConfig
	{
		[SerializeField]
		private List<IAPExclusiveGroup> groups;

		public override IReadOnlyList<string> GetGroupMembers(string productID)
		{
			return null;
		}
	}
}
