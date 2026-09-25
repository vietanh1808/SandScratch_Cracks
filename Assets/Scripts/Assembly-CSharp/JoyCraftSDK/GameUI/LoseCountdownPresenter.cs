using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class LoseCountdownPresenter : JMonoBehaviour
	{
		[Tooltip("Gate belt-full trên GameBoard — nguồn số giây còn lại (RemainingLoseSeconds). Thiếu ref -> popup vẫn hiện nhưng đếm đứng 0 (Bind null); wire để đếm đúng.")]
		[SerializeField]
		private MaxGrainGate maxGrainGate;

		private bool _shown;

		private bool _preLostActive;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnPreLost(ref AEventManager.OnPreLost eventData)
		{
		}

		private void OnPreLostEnd(ref AEventManager.OnPreLostEnd eventData)
		{
		}

		private void OnLevelLoseCondition(ref AEventManager.OnLevelLoseCondition eventData)
		{
		}

		private void OnTryExecuteBooster(ref AEventManager.OnTryExecuteBooster eventData)
		{
		}

		private void OnRevokeBooster(ref AEventManager.OnRevokeBooster eventData)
		{
		}

		private void OnCompleteBoosterExecution(ref AEventManager.OnCompleteBoosterExecution eventData)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}
	}
}
