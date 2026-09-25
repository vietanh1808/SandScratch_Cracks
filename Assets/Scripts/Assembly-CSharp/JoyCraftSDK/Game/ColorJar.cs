using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class ColorJar : JMonoBehaviour
	{
		[Serializable]
		public struct BoxReference
		{
			[Tooltip("Hiệu ứng/animation của lọ (Init màu, open/fill/collapse). Bỏ trống -> lọ vẫn chạy logic, không có FX.")]
			public AJarAnim jarAnim;

			[Tooltip("Mesh 1 của lọ (vd thân) — gán sharedMaterial lấy từ ColorDefinition.GetObjectMaterial(color).")]
			public Renderer bodyRenderer;

			[Tooltip("Mesh 2 của lọ (vd nắp/viền) — gán cùng material với mesh 1.")]
			public Renderer coverRenderer;
		}

		public BoxReference[] boxes;

		public int boxIdx;

		[Tooltip("Label hiện SỐ GRAIN còn phải thu (GrainRemaining = capacityGrains - đã thu, không về 0 tới khi jar đầy). Bỏ trống -> không hiện số, lọ vẫn chạy logic. ẨN lúc spawn, chỉ HIỆN khi lọ lên ĐẦU HÀNG (PlayOpen).")]
		[SerializeField]
		private TMP_Text fillPercentLabel;

		[Tooltip("Hệ số scale transform khi lọ LÊN ĐẦU HÀNG (head) — NHÂN với scale gốc lúc spawn. 1 = không phóng to.")]
		[SerializeField]
		private float headScale;

		[Tooltip("Thời gian (giây) tween scale khi lên/rời đầu hàng. 0 = đổi tức thì.")]
		[SerializeField]
		private float headScaleDuration;

		private GameObjectColor _color;

		private int _capacity;

		private int _receivedCount;

		private int _maxGroupSize;

		private int _capacityGrains;

		private int _inFlightCount;

		private Vector3 _baseScale;

		private Tween _headScaleTween;

		private bool _canPlayFill;

		private bool _isOpen;

		private bool _completed;

		private bool _hidden;

		private bool _isWide;

		private bool _isTall;

		private Vector3 _labelBaseScale;

		private bool _labelBaseScaleCaptured;

		private int _connectorId;

		private bool _connectorLocked;

		private ColorDefinitionSO _colorDefinition;

		[CompilerGenerated]
		private Action<ColorJar> m_OnFull;

		[CompilerGenerated]
		private Action<ColorJar> m_OnMerge;

		private AJarAnim jarAnim => null;

		private Renderer bodyRenderer => null;

		private Renderer coverRenderer => null;

		public Vector3 BaseScale => default;

		public GameObjectColor Color => GameObjectColor.None;

		public bool IsOpen => false;

		public bool IsHidden => false;

		public bool IsWide => false;

		public bool IsTall => false;

		public int ConnectorId => 0;

		public bool IsConnectorLocked => false;

		public bool IsFull => false;

		public bool HasSpace => false;

		public bool CanReceive => false;

		public int Remaining => 0;

		public int CapacityGrains => 0;

		public int GrainRemaining => 0;

		public bool HasInFlight => false;

		public event Action<ColorJar> OnFull
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<ColorJar> OnMerge
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Configure(ColorJarData colorJarData, ColorDefinitionSO colorDefinition, int maxGroupSize = 1, bool wide = false, float stretchX = 1f, bool tall = false, float stretchY = 1f)
		{
		}

		public void PlayOpen(bool deferReveal = false)
		{
		}

		private void RevealAndShowHeadOutline()
		{
		}

		public void RevealAtHead()
		{
		}

		public void ReleaseConnector()
		{
		}

		public void Reveal()
		{
		}

		public void PlayClose()
		{
		}

		public void SetHighlight(bool on)
		{
		}

		public void ReserveIncoming(int count = 1)
		{
		}

		public void ReceivePixel(int count = 1, bool consumeReservation = true)
		{
		}

		private void OnJarFull()
		{
		}

		public void PlayMergeThenComplete(Action onDone)
		{
		}

		private void UpdateCapacityLabel()
		{
		}

		private void ApplyLabelStretchCompensation(float stretchX, float stretchY = 1f)
		{
		}

		private void SetCapacityLabelVisible(bool visible)
		{
		}

		private void ApplyHeadScale(bool atHead)
		{
		}

		private void ApplyMaterial(ColorDefinitionSO colorDefinition)
		{
		}
	}
}
