using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniPay
{
	[Serializable]
	public class IAPRequirement
	{
		[SerializeField]
		public List<KeyValuePairStringInt> pairs;

		public string label;

		public bool Exists()
		{
			return false;
		}
	}
}
