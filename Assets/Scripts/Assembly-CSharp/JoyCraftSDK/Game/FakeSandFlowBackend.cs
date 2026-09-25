using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public class FakeSandFlowBackend : JMonoBehaviour, ISandFlowBackend
	{
		[Tooltip("Sức chứa vùng (pixel) -> FillRatio = RegionPixelCount / maxPixels. Ngưỡng entry 0.95 => cần ~0.95*maxPixels pixel để pause.")]
		[SerializeField]
		[Min(1f)]
		private int maxPixels;

		[Tooltip("carriedCount mỗi hạt bơm vào vùng / raise tới jar = SỐ PIXEL gom (§0m D4). Mỗi lần bấm nút +/- theo số này.")]
		[SerializeField]
		[Min(1f)]
		private int carriedCountPerParticle;

		[Tooltip("colorId (== (int)GameObjectColor) khi raise OnPixelArrivedAtJar tới jar. Đặt khớp màu head jar cần test.")]
		[SerializeField]
		private int jarColorId;

		private readonly ObiRegionCounter _counter;

		[CompilerGenerated]
		private Action<int, int> m_OnPixelArrivedAtJar;

		public int RegionPixelCount => 0;

		public float FillRatio => 0f;

		public int CarriedCountPerParticle => 0;

		public int JarColorId => 0;

		public event Action<int, int> OnPixelArrivedAtJar
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Build(PixelLevelData pixelLevelData, bool grainyLook, List<ColorJarColumnData> colorJarColumns)
		{
		}

		public void AcceptSand(SandEmitRequest request)
		{
		}

		public int GhostifyGrainsOfColor(int colorId, float releaseY)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void ResetCounter()
		{
		}

		public void PushParticleIntoRegion()
		{
		}

		public void PopParticleFromRegion()
		{
		}

		public void FillRegionFull()
		{
		}

		public void RaisePixelArrivedAtJar()
		{
		}
	}
}
