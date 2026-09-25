using TouchScript.InputSources;

namespace TouchScript.Pointers
{
	public class TouchPointer : Pointer
	{
		public const float DEFAULT_PRESSURE = 0.5f;

		public const float DEFAULT_ROTATION = 0f;

		public float Rotation { get; set; }

		public float Pressure { get; set; }

		public TouchPointer(IInputSource input)
			: base(null)
		{
		}

		internal override void INTERNAL_Reset()
		{
		}
	}
}
