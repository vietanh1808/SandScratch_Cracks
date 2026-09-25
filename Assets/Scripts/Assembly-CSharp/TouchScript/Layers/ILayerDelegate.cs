using TouchScript.Pointers;

namespace TouchScript.Layers
{
	public interface ILayerDelegate
	{
		bool ShouldReceivePointer(TouchLayer layer, IPointer pointer);
	}
}
