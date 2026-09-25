using System;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public abstract class ARopeBehaviour : JMonoBehaviour
	{
		public abstract void Setup((Transform parent, Vector3 localPos) itemA, (Transform parent, Vector3 localPos) itemB);

		public abstract void Setup(GameObjectColor objColorA, GameObjectColor objColorB);

		public abstract void Setup(Color colorA, Color colorB);

		public abstract void Test(GameObjectColor objColorA, GameObjectColor objColorB);

		public abstract void Relase(Action onDone);

		public abstract void SetPooling();
	}
}
