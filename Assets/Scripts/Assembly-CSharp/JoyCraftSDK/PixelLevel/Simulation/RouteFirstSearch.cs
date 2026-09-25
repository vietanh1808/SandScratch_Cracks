using System;
using System.Collections.Generic;
using JoyCraftSDK.Game;
using JoyCraftSDK.Utilities;

namespace JoyCraftSDK.PixelLevel.Simulation
{
	public static class RouteFirstSearch
	{
		private class MutationResult : JBase
		{
			public List<ColorJarColumnData> Columns;

			public string Description;
		}

		private struct JarPos
		{
			public int Col;

			public int Idx;
		}

		private const string ScratchDir = "Docs/Game/99_scratch";

		public const int MaxRequiredStrategies = 4;

		public static List<LevelSimStrategy> ValidateStrategies(RouteFirstSearchState state)
		{
			return null;
		}

		public static string StatePath(LevelData level)
		{
			return null;
		}

		public static RouteFirstSearchState Load(LevelData level)
		{
			return null;
		}

		public static void Save(LevelData level, RouteFirstSearchState state)
		{
		}

		public static string Init(LevelData level, LevelSimParams baseParams, RouteFirstParams routeFirstParams, SandFlowConfig cfg, IList<LevelSimStrategy> requiredStrategies)
		{
			return null;
		}

		private static RouteFirstCandidate BuildBaseCandidate(string label, LevelData level, int seed, LevelSimStrategy strategy, LevelSimParams baseParams, RouteFirstParams routeFirstParams, SandFlowConfig cfg)
		{
			return null;
		}

		private static RouteFirstCandidate BuildReflectionCandidate(LevelData level, int seed, LevelSimStrategy firstRequiredStrategy, LevelSimParams baseParams, RouteFirstParams routeFirstParams, SandFlowConfig cfg)
		{
			return null;
		}

		public static string Screen(LevelData level, SandFlowConfig cfg, int maxCandidates = 2147483647)
		{
			return null;
		}

		private static List<LevelSimParams> BuildValidateParams(IList<LevelSimStrategy> detStrategies, int seed, LevelSimParams baseParams, int beltCapacityGrains, int humanLikeRuns, int randomRuns)
		{
			return null;
		}

		private static List<LevelSimStrategy> DeterministicStrategies()
		{
			return null;
		}

		public static RouteFirstScore ComputeScore(IList<LevelSimResult> results, long elapsedMs)
		{
			return null;
		}

		public static string HillClimb(LevelData level, SandFlowConfig cfg, int topN, int variantsPerParent)
		{
			return null;
		}

		private static MutationResult MutateOnce(List<ColorJarColumnData> source, Random rng)
		{
			return null;
		}

		private static MutationResult ApplyMutationKind(int kind, List<ColorJarColumnData> source, Random rng)
		{
			return null;
		}

		private static MutationResult MutateSwap(List<ColorJarColumnData> columns, Random rng)
		{
			return null;
		}

		private static MutationResult MutateMove(List<ColorJarColumnData> columns, Random rng)
		{
			return null;
		}

		private static MutationResult MutateReverseColumn(List<ColorJarColumnData> columns, Random rng)
		{
			return null;
		}

		private static MutationResult MutateCompound(List<ColorJarColumnData> source, Random rng)
		{
			return null;
		}

		private static List<ColorJarColumnData> CloneColumns(List<ColorJarColumnData> source)
		{
			return null;
		}

		public static string HeldOut(LevelData level, SandFlowConfig cfg, int topN, int maxCandidates = 2147483647)
		{
			return null;
		}

		private static List<RouteFirstCandidate> SelectHeldOut(RouteFirstSearchState state, int topN)
		{
			return null;
		}

		public static int Compare(RouteFirstCandidate a, RouteFirstCandidate b, float humanLikeFilter)
		{
			return 0;
		}

		public static int CompareHeldOut(RouteFirstCandidate a, RouteFirstCandidate b, float humanLikeFilter)
		{
			return 0;
		}

		public static RouteFirstCandidate BestHeldOut(RouteFirstSearchState state)
		{
			return null;
		}

		public static RouteFirstSearchProgress Progress(RouteFirstSearchState state, int heldOutTopN)
		{
			return null;
		}

		public static string Report(LevelData level)
		{
			return null;
		}
	}
}
