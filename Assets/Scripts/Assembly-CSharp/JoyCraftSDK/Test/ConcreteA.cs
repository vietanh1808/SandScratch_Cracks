using System;
using UnityEngine;

namespace JoyCraftSDK.Test
{
	[Serializable]
	public class ConcreteA : BaseA
	{
		public int myIntA;

		[SerializeReference]
		public BaseB baseB;

		[SerializeReference]
		public BaseB[] baseBArray;
	}
}
