using JoyCraftSDK.Utilities;
using Lofelt.NiceVibrations;

namespace JoyCraftSDK
{
	public abstract class AHapticManager : JMonoBehaviour
	{
		public abstract void PlayRapidHaptics(HapticPatterns.PresetType preset, float duration, float interval = 0.08f);

		public abstract void StopRapidHaptics();

		public abstract void Light();

		public abstract void Medium();

		public abstract void Heavy();

		public abstract void Success();

		public abstract void Warning();

		public abstract void Failure();

		public abstract void Selection();

		public abstract void Rigid();

		public abstract void Soft();

		public abstract void Emphasis(float amplitude, float frequency = 0.5f);

		public abstract void Emphasis();

		public abstract void Constant(float amplitude, float frequency = 0.5f, float duration = 0.5f);

		public abstract void Constant();
	}
}
