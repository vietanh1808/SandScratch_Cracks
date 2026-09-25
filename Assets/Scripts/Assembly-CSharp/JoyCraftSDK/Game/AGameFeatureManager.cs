using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AGameFeatureManager : JMonoBehaviour
	{
		protected List<LevelFeaturePair> Pairs;

		protected List<IFeatureController> Controllers;

		public abstract void InitFeatureData(LevelFeatureData pairs);

		public abstract void ClearFeatureData();

		public abstract void RegisterFeatureItem(IFeatureItem item);

		public abstract void UnRegisterFeatureItem(IFeatureItem item);

		public abstract void UnregisterAll();
	}
}
