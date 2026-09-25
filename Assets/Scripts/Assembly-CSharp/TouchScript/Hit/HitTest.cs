using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Hit
{
	public abstract class HitTest : MonoBehaviour
	{
		public virtual HitResult IsHit(IPointer pointer, HitData hit)
		{
			return (HitResult)0;
		}

		private void OnEnable()
		{
		}
	}
}
