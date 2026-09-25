using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiRope))]
	public class CursorController : MonoBehaviour
	{
		public float minLength;

		public float speed;

		private ObiRopeCursor cursor;

		private ObiRope rope;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
