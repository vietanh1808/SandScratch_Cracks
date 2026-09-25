using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class CurtainAnimation : JMonoBehaviour
	{
		private const string Group_Refs = "References";

		private const string Group_Config = "Config";

		public Transform horizontal;

		public Transform leftGear;

		public Transform rightGear;

		public Transform glass;

		[SerializeField]
		private float rotationSpeed;

		[SerializeField]
		private float spinDuration;

		[SerializeField]
		private float completeDuration;

		private int direction;

		private float elapsed;

		private float spinAngle;

		private bool completing;

		private bool completed;

		private float completeElapsed;

		private Quaternion leftGearStartRotation;

		private Quaternion rightGearStartRotation;

		private Vector3 glassStartPosition;

		private Vector3 glassStartScale;

		private bool captured;

		private new void Awake()
		{
		}

		private void Update()
		{
		}

		public void RollUp()
		{
		}

		public void RollDown()
		{
		}

		public void Pause()
		{
		}

		public void PlayAtProgress(float progress)
		{
		}

		public void PlayComplete()
		{
		}

		public void ResetCurtain()
		{
		}

		private void SetProgress(float progress)
		{
		}

		private void ApplyRotation()
		{
		}

		private void TickComplete()
		{
		}

		private void CaptureStart()
		{
		}
	}
}
