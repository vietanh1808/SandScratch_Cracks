using System.Collections.Generic;
using VContainer;

namespace JoyCraftSDK.Game
{
	public class GameFeatureManager : AGameFeatureManager
	{
		[Inject]
		public void Construct(IEnumerable<IFeatureController> controllers)
		{
		}

		public override void InitFeatureData(LevelFeatureData featureData)
		{
		}

		public override void ClearFeatureData()
		{
		}

		public override void RegisterFeatureItem(IFeatureItem item)
		{
		}

		public override void UnRegisterFeatureItem(IFeatureItem item)
		{
		}

		public override void UnregisterAll()
		{
		}

		private List<LevelFeaturePair> DeepCopyPairs(List<LevelFeaturePair> source)
		{
			return null;
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}
	}
}
