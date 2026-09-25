using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class PairQueryResult
	{
		public int pairId;

		public GameFeatureType featureType;

		public bool isItemA;

		public FeatureItemRef itemRef;

		public IFeatureItem featureItem;

		public PairQueryResult(int PairId, GameFeatureType FeatureType, bool IsItemA, FeatureItemRef ItemRef, IFeatureItem Item)
		{
		}
	}
}
