namespace JoyCraftSDK.JInput
{
	public interface IClickableObject
	{
		void OnObjectClicked();

		bool CanBeClicked();

		void SetCanBeClicked(bool canBeClicked);

		void OnClickBlocked();

		int GetUniqueID();
	}
}
