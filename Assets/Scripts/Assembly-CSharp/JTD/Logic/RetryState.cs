using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JTD.Logic
{
	internal sealed record RetryState(int Attempt, bool Did429Wait, IReadOnlyDictionary<string, int> PerItemRetryCounts)
	{
		[CompilerGenerated]
		private Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int Attempt { get; set; }

		public bool Did429Wait { get; set; }

		public IReadOnlyDictionary<string, int> PerItemRetryCounts { get; set; }

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		private bool PrintMembers(StringBuilder builder)
		{
			return false;
		}

		[CompilerGenerated]
		public bool Equals(RetryState? other)
		{
			return false;
		}

		[CompilerGenerated]
		private RetryState(RetryState original)
		{
		}

		[CompilerGenerated]
		public void Deconstruct(out int Attempt, out bool Did429Wait, out IReadOnlyDictionary<string, int> PerItemRetryCounts)
		{
			Attempt = default;
			Did429Wait = default;
			PerItemRetryCounts = null;
		}
	}
}
