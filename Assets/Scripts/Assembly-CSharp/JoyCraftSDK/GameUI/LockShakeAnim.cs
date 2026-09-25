using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class LockShakeAnim : JMonoBehaviour
	{
		[SerializeField]
		private RectTransform _target;

		[SerializeField]
		private LockShakeData _data;

		private Vector3 _origEuler;

		public override void Awake()
		{
		}

		public void Play()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
