using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public abstract class AFrozenShapeLibrary : JScriptableObject
	{
		public abstract IReadOnlyList<FrozenShapeDef> Shapes { get; }

		public abstract FrozenShapeDef GetById(int id);

		public abstract bool IsIdInUse(int id);

		public abstract FrozenShapeDef AddShape(FrozenShapeKind kind);

		public abstract bool RemoveById(int id);
	}
}
