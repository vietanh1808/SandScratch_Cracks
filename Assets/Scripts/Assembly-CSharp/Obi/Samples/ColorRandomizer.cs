using UnityEngine;

namespace Obi.Samples
{
	[RequireComponent(typeof(ObiActor))]
	public class ColorRandomizer : MonoBehaviour
	{
		private ObiActor actor;

		public Gradient gradient;

		private void Start()
		{
		}

		private void Actor_OnBlueprintLoaded(ObiActor a, ObiActorBlueprint blueprint)
		{
		}
	}
}
