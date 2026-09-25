using UnityEngine;

namespace UniPay
{
	public class IAPContainer : MonoBehaviour
	{
		[HideInInspector]
		[SerializeReference]
		public IAPCategory category;

		public GameObject itemPrefab;

		public int maxCellSizeX;

		public int maxCellSizeY;

		private void Start()
		{
		}

		public void CreateShopItems()
		{
		}

		public void Reposition()
		{
		}
	}
}
