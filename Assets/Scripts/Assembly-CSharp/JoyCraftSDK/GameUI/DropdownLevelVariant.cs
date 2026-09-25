using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using UnityEngine;

namespace JoyCraftSDK.GameUI
{
	public class DropdownLevelVariant : JMonoBehaviour
	{
		private const string DefaultOptionLabel = "RC (default)";

		[SerializeField]
		private JDropdown _dropdown;

		private readonly List<string> _variantIds;

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		private void OnLevelLoaded(ref AEventManager.OnLevelLoaded eventData)
		{
		}

		private void RefreshOptions()
		{
		}

		private int ResolveSelectedIndex(int slot)
		{
			return 0;
		}

		private void OnValueChange(int index)
		{
		}

		private Dictionary<string, string> ParseOverrides()
		{
			return null;
		}
	}
}
