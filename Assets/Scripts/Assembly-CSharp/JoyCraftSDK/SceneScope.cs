using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace JoyCraftSDK
{
	public class SceneScope : LifetimeScope
	{
		[SerializeField]
		private AGameSceneManager gameSceneManager;

		protected override void Configure(IContainerBuilder builder)
		{
		}
	}
}
