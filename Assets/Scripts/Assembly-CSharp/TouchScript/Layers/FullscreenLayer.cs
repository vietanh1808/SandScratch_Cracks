using TouchScript.Hit;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Layers
{
	[AddComponentMenu("TouchScript/Layers/Fullscreen Layer")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Layers_FullscreenLayer.htm")]
	public class FullscreenLayer : TouchLayer
	{
		public enum LayerType
		{
			MainCamera = 0,
			Camera = 1,
			Global = 2
		}

		[SerializeField]
		private LayerType type;

		[SerializeField]
		private Camera _camera;

		private Transform cameraTransform;

		public LayerType Type
		{
			get
			{
				return LayerType.MainCamera;
			}
			set
			{
			}
		}

		public Camera Camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Vector3 WorldProjectionNormal => default;

		public override HitResult Hit(IPointer pointer, out HitData hit)
		{
			hit = default;
			return (HitResult)0;
		}

		protected override void Awake()
		{
		}

		protected override void setName()
		{
		}

		protected override ProjectionParams createProjectionParams()
		{
			return null;
		}

		private void updateCamera()
		{
		}

		private void cacheCameraTransform()
		{
		}
	}
}
