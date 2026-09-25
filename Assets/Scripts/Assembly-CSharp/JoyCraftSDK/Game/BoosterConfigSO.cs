using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class BoosterConfigSO : JScriptableObject
	{
		public Vector3 UsualCameraPosition;

		public Vector3 FocusPassengerPosition;

		public Vector3 FocusRunwayPosition;

		public float CameraMoveTime;

		public Ease CameraMoveEase;
	}
}
