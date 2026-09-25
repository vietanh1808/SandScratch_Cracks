using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class ColorJarSlot : JBase
	{
		public ColorJarData Jar { get; }

		public int DataColumn { get; }

		public int DataIndex { get; }

		public bool IsWide { get; }

		public bool IsWideMirror { get; }

		public bool IsTall { get; }

		public bool IsTallMirror { get; }

		public bool IsMirror => false;

		public ColorJarSlot(ColorJarData jar, int dataColumn, int dataIndex, bool isWide, bool isWideMirror, bool isTall = false, bool isTallMirror = false)
		{
		}
	}
}
