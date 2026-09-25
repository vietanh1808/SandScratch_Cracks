using JoyCraftSDK.Utilities;
using Unity.Collections;
using Unity.Mathematics;

namespace JoyCraftSDK.Game
{
	public class GrainParticlePool : JBase
	{
		private NativeArray<float2> _positions;

		private NativeArray<float2> _velocities;

		private NativeArray<float> _radii;

		private NativeArray<int> _colorIds;

		private NativeArray<int> _carried;

		private NativeArray<byte> _ghost;

		private NativeArray<float> _ghostReleaseY;

		private NativeArray<byte> _directJar;

		private int _capacity;

		private int _count;

		private bool _created;

		public bool IsCreated => false;

		public int Count => 0;

		public int Capacity => 0;

		public NativeArray<float2> Positions => default;

		public NativeArray<float2> Velocities => default;

		public NativeArray<float> Radii => default;

		public NativeArray<int> ColorIds => default;

		public NativeArray<int> Carried => default;

		public NativeArray<byte> Ghost => default;

		public NativeArray<float> GhostReleaseY => default;

		public NativeArray<byte> DirectJar => default;

		public void Alloc(int capacity)
		{
		}

		public bool Emit(float2 pos, float2 vel, float radius, int colorId, int carried, bool ghost = false, float ghostReleaseY = 0f, bool directJar = false)
		{
			return false;
		}

		public void KillBelowY(float minY)
		{
		}

		public void RemoveAt(int i)
		{
		}

		public void MarkGhost(int i, float releaseY)
		{
		}

		public void ClearDirectJar(int i)
		{
		}

		public void KillAll()
		{
		}

		public void Dispose()
		{
		}
	}
}
