using System.Text;
using TouchScript.Hit;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.Utils
{
	public static class PointerUtils
	{
		private static StringBuilder sb;

		public static bool IsPointerOnTarget(Pointer pointer)
		{
			return false;
		}

		public static bool IsPointerOnTarget(IPointer pointer, Transform target)
		{
			return false;
		}

		public static bool IsPointerOnTarget(IPointer pointer, Transform target, out HitData hit)
		{
			hit = default;
			return false;
		}

		public static string PressedButtonsToString(Pointer.PointerButtonState buttons)
		{
			return null;
		}

		public static void PressedButtonsToString(Pointer.PointerButtonState buttons, StringBuilder builder)
		{
		}

		public static string ButtonsToString(Pointer.PointerButtonState buttons)
		{
			return null;
		}

		public static void ButtonsToString(Pointer.PointerButtonState buttons, StringBuilder builder)
		{
		}

		public static Pointer.PointerButtonState DownPressedButtons(Pointer.PointerButtonState buttons)
		{
			return Pointer.PointerButtonState.Nothing;
		}

		public static Pointer.PointerButtonState PressDownButtons(Pointer.PointerButtonState buttons)
		{
			return Pointer.PointerButtonState.Nothing;
		}

		public static Pointer.PointerButtonState UpPressedButtons(Pointer.PointerButtonState buttons)
		{
			return Pointer.PointerButtonState.Nothing;
		}

		private static void initStringBuilder()
		{
		}
	}
}
