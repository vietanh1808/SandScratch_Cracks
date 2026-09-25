using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace JTD.Logic
{
	internal sealed record QueueSnapshot(IReadOnlyList<string> QueueIds, IReadOnlyList<EventContext> InFlight, bool InFlightEmpty)
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

		public IReadOnlyList<string> QueueIds { get; set; }

		public IReadOnlyList<EventContext> InFlight { get; set; }

		public bool InFlightEmpty { get; set; }

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
		public bool Equals(QueueSnapshot? other)
		{
			return false;
		}

		[CompilerGenerated]
		private QueueSnapshot(QueueSnapshot original)
		{
		}

		[CompilerGenerated]
		public void Deconstruct(out IReadOnlyList<string> QueueIds, out IReadOnlyList<EventContext> InFlight, out bool InFlightEmpty)
		{
			QueueIds = null;
			InFlight = null;
			InFlightEmpty = default;
		}
	}
}
