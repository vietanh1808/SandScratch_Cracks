using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.RemoteConfig
{
	[CreateAssetMenu(menuName = "FirebaseRemoteConfigData", fileName = "FirebaseRemoteConfigData")]
	public class FirebaseRemoteConfigData : JScriptableObject
	{
		public RemoteConfigData data;
	}
}
