using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiRope))]
	public class RopeSweepCut : MonoBehaviour
	{
		public Camera cam;

		private ObiRope rope;

		private LineRenderer lineRenderer;

		private Vector3 cutStartPosition;

		private Vector3 cutEndPosition;

		private bool cut;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void AddMouseLine()
		{
		}

		private void DeleteMouseLine()
		{
		}

		private void LateUpdate()
		{
		}

		private void Rope_OnBeginSimulation(ObiActor actor, float stepTime, float substepTime)
		{
		}

		private void ProcessInput()
		{
		}

		private void ScreenSpaceCut(Vector2 lineStart, Vector2 lineEnd)
		{
		}

		private bool SegmentSegmentIntersection(Vector2 A, Vector2 B, Vector2 C, Vector2 D, out float r, out float s)
		{
			r = default;
			s = default;
			return false;
		}
	}
}
