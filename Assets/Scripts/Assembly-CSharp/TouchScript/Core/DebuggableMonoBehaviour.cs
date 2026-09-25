using UnityEngine;

namespace TouchScript.Core
{
	public class DebuggableMonoBehaviour : MonoBehaviour, IDebuggable
	{
		public virtual bool DebugMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
