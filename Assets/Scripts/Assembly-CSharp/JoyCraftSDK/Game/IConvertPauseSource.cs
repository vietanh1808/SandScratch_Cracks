using System;

namespace JoyCraftSDK.Game
{
	public interface IConvertPauseSource
	{
		bool ConvertPaused { get; }

		event Action<bool> OnConvertPauseChanged;
	}
}
