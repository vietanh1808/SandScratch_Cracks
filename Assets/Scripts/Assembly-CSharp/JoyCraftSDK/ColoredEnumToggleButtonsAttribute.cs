using System;

namespace JoyCraftSDK
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ColoredEnumToggleButtonsAttribute : Attribute
	{
		public float r;

		public float g;

		public float b;

		public ColoredEnumToggleButtonsAttribute(float r = 0.45f, float g = 0.9f, float b = 0.45f)
		{
		}
	}
}
