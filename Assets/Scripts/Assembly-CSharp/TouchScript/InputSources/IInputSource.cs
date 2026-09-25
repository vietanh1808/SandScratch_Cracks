using TouchScript.Pointers;

namespace TouchScript.InputSources
{
	public interface IInputSource : INTERNAL_IInputSource
	{
		ICoordinatesRemapper CoordinatesRemapper { get; set; }

		bool UpdateInput();

		void UpdateResolution();

		bool CancelPointer(Pointer pointer, bool shouldReturn);
	}
}
