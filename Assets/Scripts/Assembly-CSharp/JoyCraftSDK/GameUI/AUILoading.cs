using JoyCraftSDK.Utilities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.GameUI
{
	public class AUILoading : JMonoBehaviour
	{
		public Image loadingBg;

		public TMP_Text loadingLb;

		public Slider progressBar;

		public Canvas root;

		public virtual void ChangeLoadingBackground(Sprite sprite)
		{
		}

		public virtual void Write(string s)
		{
		}

		public virtual void Progress(float to, float speed)
		{
		}
	}
}
