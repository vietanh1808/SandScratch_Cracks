using TouchScript.InputSources;

namespace TouchScript.Pointers
{
	public class ObjectPointer : Pointer
	{
		public const int DEFAULT_OBJECT_ID = 0;

		public const float DEFAULT_WIDTH = 1f;

		public const float DEFAULT_HEIGHT = 1f;

		public const float DEFAULT_ANGLE = 0f;

		public int ObjectId { get; internal set; }

		public float Width { get; internal set; }

		public float Height { get; internal set; }

		public float Angle { get; internal set; }

		public ObjectPointer(IInputSource input)
			: base(null)
		{
		}

		public override void CopyFrom(Pointer target)
		{
		}

		internal override void INTERNAL_Reset()
		{
		}
	}
}
