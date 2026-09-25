using System;
using Cysharp.Threading.Tasks;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK
{
	public abstract class ATimeManager : JMonoBehaviour
	{
		public abstract float GameSpeed { get; set; }

		public abstract bool IsPaused { get; }

		public abstract float TotalGameTime { get; }

		public abstract float TotalLevelTime { get; }

		public abstract float DeltaTime { get; }

		public abstract float FixedDeltaTime { get; }

		public float UnscaledDeltaTime => 0f;

		public float UnscaledFixedDeltaTime => 0f;

		public SerializedDateTime TimeNow => null;

		public virtual DateTime UtcNow => default;

		public virtual UniTask SyncServerTimeAsync()
		{
			return default;
		}

		public abstract void PauseGameTime();

		public abstract void ContinueGameTime();

		public abstract void ForceResumeGameTime();
	}
}
