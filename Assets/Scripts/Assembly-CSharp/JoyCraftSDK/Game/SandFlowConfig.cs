using UnityEngine;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "SandFlowConfig", menuName = "GameSDK/SandFlowConfig")]
	public class SandFlowConfig : ASandFlowConfig
	{
		private const string Group_Configs = "Configs (single-source hệ cát)";

		[Tooltip("Preset cỡ stadium conveyor (bodyLength/channelWidth/innerHole/capacity). Đọc bởi ConveyorController (bake stadium vào field gộp) + GrainFlowBackend (dựng tường SDF + MaxGrainsManual).")]
		[SerializeField]
		private ConveyorShapeData conveyorShapeData;

		[Tooltip("Knob feel + hình học (Grain* / phễu / chute / khung / convert). Đọc bởi GrainFlowBackend (LIVE mỗi step -> tune Inspector khỏi rebuild) + ConversionFront (waveInterval/maxGroupSize/emit).")]
		[SerializeField]
		private GrainTuningConfig tuningConfig;

		[Tooltip("Pose rig + pose tranh (SandQuadRoot) + RigGeometryScale. Đọc bởi LevelSpawner (ApplyQuadRootPose), GrainFlowBackend (neo SDF), PictureColliderBuilder (gizmo căn tranh, EDIT-TIME).")]
		[SerializeField]
		private ObiFlowLayoutConfig layoutConfig;

		[Tooltip("Thư viện hình băng (Frozen Picture) — preset cỡ dùng CHUNG mọi level; level chỉ giữ placement trỏ id. Đọc bởi PictureColliderBuilder (raster mặt nạ chặn cào lúc Build). Để TRỐNG được: level không có hình băng chạy bình thường; chỉ level CÓ hình băng mới cần.")]
		[SerializeField]
		private AFrozenShapeLibrary frozenShapeLibrary;

		public override ConveyorShapeData ConveyorShape => null;

		public override GrainTuningConfig TuningConfig => null;

		public override ObiFlowLayoutConfig LayoutConfig => null;

		public override AFrozenShapeLibrary FrozenShapeLibrary => null;
	}
}
