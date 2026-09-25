using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Hit
{
	[AddComponentMenu("TouchScript/Behaviors/Untouchable")]
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Hit_Untouchable.htm")]
	public class Untouchable : HitTest
	{
		public bool DiscardPointer;

		public override HitResult IsHit(IPointer pointer, HitData hit)
		{
			return (HitResult)0;
		}
	}
}
