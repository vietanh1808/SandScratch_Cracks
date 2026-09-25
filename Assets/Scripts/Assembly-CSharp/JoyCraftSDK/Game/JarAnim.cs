using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Animancer;
using HighlightPlus;
using JoyCraftSDK.Utilities;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class JarAnim : AJarAnim
	{
		[CompilerGenerated]
		private sealed class _003CInvokeWhenFeedbackDone_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action onComplete;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInvokeWhenFeedbackDone_003Ed__38(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInvokeWhenFeedbackFullyDone_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MMF_Player player;

			public JarAnim _003C_003E4__this;

			public Action onComplete;

			private float _003CmaxDuration_003E5__2;

			private float _003ChideAt_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInvokeWhenFeedbackFullyDone_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string Group_Anim = "Anim / FX";

		private const string Group_BoosterOutline = "Booster Shuffle Outline";

		private const string Group_HeadOutline = "Head Outline";

		private const string Group_HiddenReveal = "Hidden Reveal";

		[Tooltip("Root child 'Hidden Visual' (lớp phủ '?') — ACTIVE sẵn trong prefab. SetHidden bật/tắt theo lọ ẩn hay thường; lộ = chỉ chơi MMF (không SetActive). Bỏ trống -> SetHidden/PlayRevealBurst no-op.")]
		public GameObject hiddenRevealVisual;

		[Tooltip("MMF 'FB - Unlock Hidden' TRONG hiddenRevealVisual — burst chơi 1 LẦN khi HIDDEN box lộ màu (gọi từ ColorJar.Reveal). Bỏ trống -> chỉ SetActive, không có burst MMF.")]
		public MMF_Player hiddenRevealFb;

		public MMF_Player mergedFb;

		public MMF_Player fillFb;

		public AnimancerComponent animancer;

		public AnimationClip idleClip;

		public AnimationClip closeClip;

		public AnimationClip openClip;

		public SmokeEffect smokeEffect;

		public float mergedAnimTime;

		[Tooltip("Viền BOOSTER box-swap — code chỉ bật/tắt .highlighted; MÀU/GLOW/độ dày cấu hình TRỰC TIẾP trên HighlightEffect này trong prefab, KHÔNG có knob script (khác hệ head).")]
		public HighlightEffect highlightEffect;

		[Tooltip("HighlightEffect RIÊNG cho viền lúc lọ LÊN ĐẦU HÀNG — TÁCH khỏi highlightEffect (booster box-swap) để 2 trạng thái độc lập, không giẫm cờ nhau. Bỏ trống -> viền head tắt, lọ vẫn chạy logic.")]
		public HighlightEffect headOutlineEffect;

		[Tooltip("Độ DÀY viền head — map thẳng vào HighlightEffect.outlineWidth.")]
		public float headOutlineWidth;

		[Tooltip("KNOB chọn màu viền head: FollowJarColor = glow/outline theo màu lọ; FixedShuffleStyle = màu cố định giống booster shuffle (dùng 2 field headOutlineFixed* dưới).")]
		public HeadOutlineColorMode headOutlineColorMode;

		[Tooltip("Cường độ GLOW viền head — map vào HighlightEffect.glow. 0 = tắt glow (chỉ còn outline).")]
		public float headOutlineGlow;

		[Tooltip("Độ RỘNG glow viền head — map vào HighlightEffect.glowWidth.")]
		public float headOutlineGlowWidth;

		[Tooltip("[FixedShuffleStyle] Màu OUTLINE cố định (HDR) — default copy màu viền booster shuffle.")]
		[ColorUsage(true, true)]
		public Color headOutlineFixedOutlineColor;

		[Tooltip("[FixedShuffleStyle] Màu GLOW cố định (HDR) — default copy màu glow booster shuffle.")]
		[ColorUsage(true, true)]
		public Color headOutlineFixedGlowColor;

		private static int _headOutlineOnCount;

		private bool _headOutlineOn;

		private void HoldIdle()
		{
		}

		private void ResumeGraph()
		{
		}

		private void Init()
		{
		}

		public override void SetHighlightEffect(bool isActive)
		{
		}

		public override void SetHeadOutline(bool isActive, Color color)
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Init(GameObjectColor color)
		{
		}

		public override void SetHidden(bool isHidden)
		{
		}

		public override void PlayRevealBurst()
		{
		}

		public void PlayEffectMerge()
		{
		}

		public override void PlayEffectMerge(Action onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeWhenFeedbackFullyDone_003Ed__35))]
		private IEnumerator InvokeWhenFeedbackFullyDone(MMF_Player player, Action onComplete)
		{
			return null;
		}

		public void PlayEffectFill()
		{
		}

		public override void PlayEffectFill(Action onComplete)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeWhenFeedbackDone_003Ed__38))]
		private IEnumerator InvokeWhenFeedbackDone(MMF_Player player, Action onComplete)
		{
			return null;
		}

		public void PlayAnimCollapse()
		{
		}

		public override void PlayAnimCollapse(Action onComplete)
		{
		}

		public void PlayAnimOpen()
		{
		}

		public override void PlayAnimOpen(Action onComplete)
		{
		}

		public override void PlayAnimClose()
		{
		}

		public override void PlayEffectFill(float progress)
		{
		}
	}
}
