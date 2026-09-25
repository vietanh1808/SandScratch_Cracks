using UnityEngine;

namespace JoyCraftSDK.RateApp
{
	[CreateAssetMenu(fileName = "RateAppConfig", menuName = "GameSDK/RateAppConfig")]
	public class RateAppConfig : ARateAppConfig
	{
		[Tooltip("Ràng buộc cho lần hỏi ĐẦU TIÊN (promptCount == 0).")]
		[SerializeField]
		private RatePromptConstraint initialConstraint;

		[Tooltip("Ràng buộc cho lần hỏi kế (đã từng hỏi + app lên version mới).")]
		[SerializeField]
		private RatePromptConstraint repeatConstraint;

		[Tooltip("Để TRỐNG = zero-config (StoreLinkResolver tự suy từ Application.identifier). Chỉ điền khi bundleId khác store listing id.")]
		[SerializeField]
		private string storeIdOverride;

		public override RatePromptConstraint InitialConstraint => null;

		public override RatePromptConstraint RepeatConstraint => null;

		public override string StoreIdOverride => null;
	}
}
