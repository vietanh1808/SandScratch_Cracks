using UnityEngine;

namespace Crystal
{
	public class SafeAreaDemo : MonoBehaviour
	{
		[SerializeField]
		private KeyCode KeySafeArea;

		[SerializeField]
		private SafeArea.SimDevice StartupSim;

		private SafeArea.SimDevice[] Sims;

		private int SimIdx;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void ToggleSafeArea()
		{
		}

		public void SetSafeArea(SafeArea.SimDevice sim)
		{
		}
	}
}
