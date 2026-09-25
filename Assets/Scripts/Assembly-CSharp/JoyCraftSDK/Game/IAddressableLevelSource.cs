using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public interface IAddressableLevelSource
	{
		UniTask<ALevelData> PreloadLevel(int level, bool background = false);

		ReleaseDifficulty GetDifficulty(int level);

		string GetVariantId(int level);

		int GetVariantSlot(int level);

		IReadOnlyList<string> GetVariantIds(int level);

		void PrefetchUpcomingBand(int level);
	}
}
