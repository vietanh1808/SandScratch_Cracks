namespace JoyCraftSDK.PixelLevel.Simulation
{
	public readonly struct FrozenGroupDiag
	{
		public readonly int GroupId;

		public readonly int Col;

		public readonly int PyMin;

		public readonly int PyMax;

		public readonly int CountInitial;

		public readonly int CountLeftNow;

		public readonly bool Active;

		public readonly int RevealMoveIndex;

		public readonly int JarsLeftAtReveal;

		public readonly int CountLeftAtReveal;

		public FrozenGroupDiag(int groupId, int col, int pyMin, int pyMax, int countInitial, int countLeftNow, bool active, int revealMoveIndex, int jarsLeftAtReveal, int countLeftAtReveal)
		{
			GroupId = 0;
			Col = 0;
			PyMin = 0;
			PyMax = 0;
			CountInitial = 0;
			CountLeftNow = 0;
			Active = false;
			RevealMoveIndex = 0;
			JarsLeftAtReveal = 0;
			CountLeftAtReveal = 0;
		}
	}
}
