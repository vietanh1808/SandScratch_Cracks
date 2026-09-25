using System.Collections.Generic;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.TrophyRoom
{
	public abstract class ATrophyRoomManager : JBase
	{
		public abstract bool IsActive { get; }

		public abstract bool IsUnlocked { get; }

		public abstract IReadOnlyList<TrophyRoomDef> Rooms { get; }

		public abstract TrophyRoomDef CurrentRoom { get; }

		public abstract IReadOnlyList<TrophyItemDef> Items { get; }

		public abstract int OwnedCount { get; }

		public abstract bool IsAllRoomsComplete { get; }

		public abstract bool HasVisited { get; }

		public abstract void Initialize();

		public abstract int GetStarsForDifficulty(ReleaseDifficulty difficulty);

		public abstract TrophyRoomDef GetRoom(int roomId);

		public abstract bool IsOwned(int id);

		public abstract int GetOwnedCountInRoom(int roomId);

		public abstract bool IsRoomComplete(int roomId);

		public abstract TrophyItemDef GetNextItem();

		public abstract bool CanBuyItem(int itemId);

		public abstract bool TryBuyItem(int itemId);

		public abstract bool TryGetPendingCompletion(out int roomId, out IReadOnlyList<TrophyRoomReward> rewards);

		public abstract void AcknowledgeRoomCompletion();

		public abstract void MarkVisited();

		public abstract void DebugResetRoom();

		public abstract string DebugDescribeState();
	}
}
