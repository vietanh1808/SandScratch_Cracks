using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.Game
{
	public class ColorJarLayout : JBase
	{
		private readonly List<List<ColorJarSlot>> columns;

		private readonly List<string> errors;

		private readonly HashSet<(int dataColumn, int dataIndex)> invalidWideKeys;

		public int ColumnCount { get; }

		public IReadOnlyList<string> Errors => null;

		private ColorJarLayout(List<List<ColorJarSlot>> columns, List<string> errors, HashSet<(int dataColumn, int dataIndex)> invalidWideKeys)
		{
		}

		public IReadOnlyList<ColorJarSlot> GetColumn(int column)
		{
			return null;
		}

		public bool IsWideInvalid(int dataColumn, int dataIndex)
		{
			return false;
		}

		public static ColorJarLayout Resolve(IReadOnlyList<ColorJarColumnData> columns)
		{
			return null;
		}
	}
}
