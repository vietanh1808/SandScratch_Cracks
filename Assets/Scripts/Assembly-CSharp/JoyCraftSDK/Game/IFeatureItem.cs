using System;
using UnityEngine;

namespace JoyCraftSDK.Game
{
	public interface IFeatureItem
	{
		string GetName();

		Enum GetFeatureType();

		(int, int) GetIndex();

		void OnInitFeature();

		void OnFulfilledFeature();

		(Transform, Vector3) GetTransform();
	}
}
