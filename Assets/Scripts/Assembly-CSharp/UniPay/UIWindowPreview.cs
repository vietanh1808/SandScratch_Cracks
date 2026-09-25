using System.Collections.Generic;
using UnityEngine;

namespace UniPay
{
	public class UIWindowPreview : MonoBehaviour
	{
		public Transform container;

		public GameObject itemPrefab;

		public bool includeChildRewards;

		public void Set(List<KeyValuePairStringInt> products)
		{
		}

		private void OnDisable()
		{
		}
	}
}
