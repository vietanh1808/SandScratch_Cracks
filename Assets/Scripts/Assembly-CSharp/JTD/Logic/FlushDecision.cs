using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JTD.Logic
{
	internal sealed record FlushDecision(FlushAction Action, IReadOnlyList<string> DequeueIds, IReadOnlyList<EventContext> PrependEvents, bool Persist, int BackoffMs, bool Did429WaitNext, IReadOnlyList<string> PoisonDropIds)
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

		public FlushAction Action { get; set; }

		public IReadOnlyList<string> DequeueIds { get; set; }

		public IReadOnlyList<EventContext> PrependEvents { get; set; }

		public bool Persist { get; set; }

		public int BackoffMs { get; set; }

		public bool Did429WaitNext { get; set; }

		public IReadOnlyList<string> PoisonDropIds { get; set; }

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
		public bool Equals(FlushDecision? other)
		{
			return false;
		}

		[CompilerGenerated]
		private FlushDecision(FlushDecision original)
		{
		}

		[CompilerGenerated]
		public void Deconstruct(out FlushAction Action, out IReadOnlyList<string> DequeueIds, out IReadOnlyList<EventContext> PrependEvents, out bool Persist, out int BackoffMs, out bool Did429WaitNext, out IReadOnlyList<string> PoisonDropIds)
		{
			Action = default;
			DequeueIds = null;
			PrependEvents = null;
			Persist = default;
			BackoffMs = default;
			Did429WaitNext = default;
			PoisonDropIds = null;
		}
	}
}
