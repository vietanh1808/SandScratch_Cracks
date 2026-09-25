using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ATimedBuffManager : JBase
	{
		public abstract void RecalculateActiveBuffs();

		public abstract void Activate(BuffType type, float durationSeconds);

		public abstract void Deactivate(BuffType type);

		public abstract bool IsActive(BuffType type);

		public abstract float GetRemainingSeconds(BuffType type);

		public abstract float GetMagnitude(BuffType type);

		public abstract IReadOnlyCollection<BuffType> GetActiveBuffs();
	}
}
