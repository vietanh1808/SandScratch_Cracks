using System.Collections.Generic;
using UnityEngine;

namespace TouchScript.Behaviors.Cursors.UI
{
	[HelpURL("http://touchscript.github.io/docs/html/T_TouchScript_Behaviors_Cursors_UI_GradientTexture.htm")]
	public class GradientTexture : MonoBehaviour
	{
		public enum Res
		{
			Pix16 = 0x10,
			Pix32 = 0x20,
			Pix64 = 0x40,
			Pix128 = 0x80,
			Pix256 = 0x100,
			Pix512 = 0x200
		}

		public Gradient Gradient;

		public string Name;

		public Res Resolution;

		private Texture2D texture;

		private static Dictionary<int, Texture2D> textureCache;

		public Texture2D Generate()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		private void refresh()
		{
		}

		private void apply()
		{
		}
	}
}
