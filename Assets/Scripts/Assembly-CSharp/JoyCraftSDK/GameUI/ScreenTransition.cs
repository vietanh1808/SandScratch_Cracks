using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class ScreenTransition : JMonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayGatedAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ScreenTransition _003C_003E4__this;

			public Func<UniTask> coveredJob;

			public Action onDone;

			private float _003Copen_003E5__2;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string ConfigResourceName = "ScreenTransitionConfig";

		private static readonly int RadiusId;

		private static readonly int SoftId;

		private static readonly int AspectId;

		private static readonly int ColorId;

		private static ScreenTransition _instance;

		private AScreenTransitionConfig _config;

		private GameObject _holder;

		private Image _veil;

		private Material _mat;

		private Sequence _seq;

		private float _radius;

		private bool _playing;

		public static ScreenTransition Instance => null;

		public void Play(Action onCovered, Action onDone = null, float holdDuration = -1f)
		{
		}

		public void Play(Func<UniTask> coveredJob, Action onDone = null)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayGatedAsync_003Ed__17))]
		private UniTaskVoid PlayGatedAsync(Func<UniTask> coveredJob, Action onDone)
		{
			return default;
		}

		private UniTask RunRadiusTween(float target, float duration, Ease ease)
		{
			return default;
		}

		protected override void OnDestroy()
		{
		}

		private float GetRadius()
		{
			return 0f;
		}

		private void SetRadius(float r)
		{
		}

		private float OpenRadius()
		{
			return 0f;
		}

		private static ScreenTransition Create()
		{
			return null;
		}

		private void BuildChildren(Transform parent)
		{
		}

		private static void Stretch(RectTransform rt)
		{
		}

		private static Sprite CreateWhiteSprite()
		{
			return null;
		}
	}
}
