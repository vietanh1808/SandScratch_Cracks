using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	[Serializable]
	[CreateAssetMenu(fileName = "ConveyorShapeData", menuName = "GameSDK/ConveyorShapeData")]
	public class ConveyorShapeData : AConveyorShapeData
	{
		[Tooltip("Chiều dài đoạn thẳng thân (world) — NÚT TĂNG SIZE/CAPACITY CHÍNH (physics feel không đổi).")]
		[SerializeField]
		private float bodyLength;

		[Tooltip("Bề rộng rãnh (world). Đổi feel dòng cát + art phải vẽ lại -> chỉnh CÓ CHỦ ĐÍCH. Nên >= 6-8 cell theo PPU.")]
		[SerializeField]
		private float channelWidth;

		[Tooltip("Độ dày vành tường NGOÀI (cell) — vành có ô hở entry.")]
		[FormerlySerializedAs("wallThicknessCells")]
		[SerializeField]
		private int outerWallThicknessCells;

		[Tooltip("BÁN KÍNH khoảng trống lõi (world) — stadium TRỐNG trong cùng, vành trong bao sát quanh nó. Chiều ngang trống = bodyLength + 2×innerHoleRadius; 0 = lõi lấp ĐẶC. Đây là nút chỉnh cỡ vòng chạy: bán kính cua derive = innerHoleRadius + vành trong + channelWidth/2.")]
		[SerializeField]
		private float innerHoleRadius;

		[Tooltip("Độ dày vành tường TRONG (cell) — bao sát quanh khoảng trống lõi.")]
		[SerializeField]
		private int innerWallThicknessCells;

		[SerializeField]
		private ConveyorCapacityMode conveyorCapacityMode;

		[Tooltip("Manual: số hạt tối đa tuyệt đối (clamp về sức chứa vật lý rãnh).")]
		[SerializeField]
		private int maxPixelsManual;

		[Tooltip("AutoFillRatio: tỉ lệ lấp rãnh (0..1) × số cell rãnh.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float fillRatio;

		[Tooltip("Số HẠT grain tối đa belt chứa (MaxGrainGate FillRatio denom, backend GrainBurst). KHÁC maxPixelsManual (đơn vị pixel, grid/Obi). ⚠ Giá trị KHÔNG tự chuyển từ GrainTuningConfig -> nhập tay.")]
		[SerializeField]
		[Min(1f)]
		private int maxGrainsManual;

		public override float BodyLength => 0f;

		public override float ChannelWidth => 0f;

		public override int OuterWallThicknessCells => 0;

		public override float InnerHoleRadius => 0f;

		public override int InnerWallThicknessCells => 0;

		public override ConveyorCapacityMode CapacityMode => ConveyorCapacityMode.Manual;

		public override int MaxPixelsManual => 0;

		public override float FillRatio => 0f;

		public override int MaxGrainsManual => 0;
	}
}
