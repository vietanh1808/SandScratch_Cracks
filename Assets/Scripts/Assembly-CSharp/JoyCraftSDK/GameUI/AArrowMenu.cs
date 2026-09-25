using System.Collections.Generic;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;

namespace JoyCraftSDK.GameUI
{
	public abstract class AArrowMenu<T> : JMonoBehaviour
	{
		public readonly Relay<T> OnSelectionChanged;

		public abstract T CurrentOption { get; }

		public abstract void Init();

		public abstract void SelectPrevious();

		public abstract void SelectNext();

		public abstract void SetOptions(List<T> newOptions);

		public abstract void SetIndex(int index);

		public abstract void SetIndexSilent(int index);
	}
}
