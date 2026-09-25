using System;

namespace JoyCraftSDK.Game
{
	public interface IFeatureController
	{
		void Register(IFeatureItem item);

		void Unregister(IFeatureItem item);

		void UnregisterAll();

		bool CanHandle(Enum feature);
	}
}
