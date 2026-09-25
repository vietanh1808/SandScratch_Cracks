using UnityEngine;

namespace JoyCraftSDK.Game
{
	public interface IFeatureCountingVisual : IFeatureVisual
	{
		void Init(int count);

		void TryFulfilledFeature();

		Transform GetTransform();
	}
}
