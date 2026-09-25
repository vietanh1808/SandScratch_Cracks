using UnityEngine;

namespace TouchScript.InputSources
{
	public interface ICoordinatesRemapper
	{
		Vector2 Remap(Vector2 input);
	}
}
