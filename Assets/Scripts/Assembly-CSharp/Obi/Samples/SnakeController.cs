using UnityEngine;

namespace Obi.Samples
{
	public class SnakeController : MonoBehaviour
	{
		public Transform headReferenceFrame;

		public float headSpeed;

		public float upSpeed;

		public float slitherSpeed;

		private ObiRope rope;

		private ObiSolver solver;

		private float[] traction;

		private Vector3[] surfaceNormal;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void ResetSurfaceInfo(ObiActor a, float simulatedTime, float substepTime)
		{
		}

		private void AnalyzeContacts(object sender, ObiNativeContactList e)
		{
		}
	}
}
