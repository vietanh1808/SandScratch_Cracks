using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JTD.Logic
{
	internal sealed record RevenueEnqueuePlan(IReadOnlyList<RevenueOp> Ops)
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

		public IReadOnlyList<RevenueOp> Ops { get; set; }

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
		public bool Equals(RevenueEnqueuePlan? other)
		{
			return false;
		}

		[CompilerGenerated]
		private RevenueEnqueuePlan(RevenueEnqueuePlan original)
		{
		}

		[CompilerGenerated]
		public void Deconstruct(out IReadOnlyList<RevenueOp> Ops)
		{
			Ops = null;
		}
	}
}
