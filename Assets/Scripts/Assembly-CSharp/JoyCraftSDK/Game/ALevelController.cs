using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class ALevelController : JBase
	{
		private static readonly IReadOnlyList<string> BaseVariantIdOnly;

		protected abstract ALevelDatabase CurrentDatabase { get; set; }

		public abstract ALevelData LevelData { get; protected set; }

		public abstract ColorDefinitionSO ColorDefinition { get; }

		public virtual string CurrentVariantId => null;

		public abstract void Initialize();

		public abstract int GetCurrentLevel();

		public abstract int GetMaxLevel();

		public abstract bool IsLevelStart();

		public abstract bool IsLevelFinished();

		public abstract bool IsInLevel();

		public abstract ReleaseDifficulty GetLevelDifficulty(int level = -1);

		public virtual int GetCurrentVariantSlot()
		{
			return 0;
		}

		public virtual IReadOnlyList<string> GetCurrentVariantIds()
		{
			return null;
		}

		public abstract void LoadCurrentLevel(LevelPlayType playType);

		public abstract void LoadCustomLevel(int level);

		public abstract void UnloadCurrentLevel();

		public abstract void SetFinishLevel(bool isFinished);
	}
}
