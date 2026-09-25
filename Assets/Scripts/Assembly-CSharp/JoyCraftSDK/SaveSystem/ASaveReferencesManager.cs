using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.SaveSystem
{
	public abstract class ASaveReferencesManager : JMonoBehaviour
	{
		public abstract Object GetReference(string saveUniqueId);
	}
}
