using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JoyCraftSDK.Utilities
{
	public static class Extensions
	{
		[CompilerGenerated]
		private sealed class _003CWaitForCondition_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Func<bool> condition;

			public float requiredDuration;

			private float _003CelapsedTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CWaitForCondition_003Ed__130(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static string FormatCoinString(double amount)
		{
			return null;
		}

		public static Vector3 AddFloat(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 AddToX(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 AddToY(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 AddToZ(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 MultX(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 MultY(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 MultZ(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 Mult(this Vector3 vector, Vector3 other)
		{
			return default;
		}

		public static Vector3 Divide(this Vector3 vector, Vector3 other)
		{
			return default;
		}

		public static Vector3 SetX(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 SetY(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 SetZ(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 SetAll(this Vector3 vector, float value)
		{
			return default;
		}

		public static Vector3 ToVector3(this float value)
		{
			return default;
		}

		public static Vector3 ToVector3(this int value)
		{
			return default;
		}

		public static Vector3 ToWorldPosition(this Vector3 screenPos, float z = 0f)
		{
			return default;
		}

		public static Vector2 xy(this Vector3 value)
		{
			return default;
		}

		public static Vector2 xz(this Vector3 value)
		{
			return default;
		}

		public static Vector3 Round(this Vector3 vector, int decimalPlaces = 2)
		{
			return default;
		}

		public static Vector3 GetRandomPositionAroundObject(this Vector3 position, float minRadius, float maxRadius)
		{
			return default;
		}

		public static Vector3 GetRandomPositionAroundObject(this Vector3 position, float radius)
		{
			return default;
		}

		public static Vector3 GetRandomPosition(this Bounds bounds)
		{
			return default;
		}

		public static Vector3 GetRandomPosition(this Bounds bounds, Quaternion rotation, float offset = 0f)
		{
			return default;
		}

		public static Vector3 xyz(this Vector4 value)
		{
			return default;
		}

		public static Vector2 xy(this Vector4 value)
		{
			return default;
		}

		public static Vector2 AddFloat(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 AddToX(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 AddToY(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 MultX(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 MultY(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 SetX(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 SetY(this Vector2 vector, float value)
		{
			return default;
		}

		public static Vector2 ToVector2(this float value)
		{
			return default;
		}

		public static Vector2 ToVector2(this int value)
		{
			return default;
		}

		public static Vector3 ToVector3(this Vector2 vector, float z = 0f)
		{
			return default;
		}

		public static Vector2 Round(this Vector2 vector, int decimalPlaces = 2)
		{
			return default;
		}

		public static Vector2Int AddValue(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int AddToX(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int AddToY(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int MultX(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int MultY(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int SetX(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int SetY(this Vector2Int vector, int value)
		{
			return default;
		}

		public static Vector2Int ToVector2Int(this int value)
		{
			return default;
		}

		public static Vector3 ToVector3(this Vector2Int vector, float z = 0f)
		{
			return default;
		}

		public static void FlipVector3(this IList<Vector3> list, int flipX = 1, int flipY = 1)
		{
		}

		public static void FlipX(this Transform transform, bool flip)
		{
		}

		public static void FlipY(this Transform transform, bool flip)
		{
		}

		public static Transform TryGetChild(this Transform transform, int index)
		{
			return null;
		}

		public static List<Transform> GetImmediateChildren(this Transform parent)
		{
			return null;
		}

		public static void DestroyChildren(this Transform parent)
		{
		}

		public static void DestroyChildrenImmediate(this Transform parent)
		{
		}

		public static void SetChildActive(this Transform parent, bool on, int exceptionIndex = -1)
		{
		}

		public static Transform ResetLocal(this Transform transform)
		{
			return null;
		}

		public static Transform ResetGlobal(this Transform transform)
		{
			return null;
		}

		public static Transform SetPositionX(this Transform transform, float x)
		{
			return null;
		}

		public static Transform SetPositionY(this Transform transform, float y)
		{
			return null;
		}

		public static Transform SetPositionZ(this Transform transform, float z)
		{
			return null;
		}

		public static void SetActive(this IEnumerable<GameObject> collection, bool on)
		{
		}

		public static string Bold(this string str)
		{
			return null;
		}

		public static string Italic(this string str)
		{
			return null;
		}

		public static string Color(this string str, string color)
		{
			return null;
		}

		public static string Color(this string str, JColor color)
		{
			return null;
		}

		public static string Size(this string str, int size)
		{
			return null;
		}

		public static string FirstCharToLowerCase(this string str)
		{
			return null;
		}

		public static string ToTimeFormat(this int seconds)
		{
			return null;
		}

		public static string ToTimeFormat(this long seconds)
		{
			return null;
		}

		public static string ToTimeFormatCompact(this int seconds)
		{
			return null;
		}

		public static string ToTimeFormatCompact(this long seconds)
		{
			return null;
		}

		public static IList<int> AllIndexOf(this string text, string str, StringComparison comparisonType)
		{
			return null;
		}

		public static string ReplaceAt(this string value, int index, char newChar)
		{
			return null;
		}

		public static string ToFormatString(this long value)
		{
			return null;
		}

		public static string ToFormatString(this int value)
		{
			return null;
		}

		public static string ToFormatString(this double value)
		{
			return null;
		}

		public static string ToQuantityString(this long value)
		{
			return null;
		}

		public static string ToQuantityString(this int value)
		{
			return null;
		}

		public static string ToQuantityString(this double value)
		{
			return null;
		}

		public static string ToCountFormat(this int value, int digits)
		{
			return null;
		}

		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return false;
		}

		public static bool IsNullOrEmpty<T>(this T[] array)
		{
			return false;
		}

		public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return false;
		}

		public static bool HasNullItem<T>(this IEnumerable<T> collection)
		{
			return false;
		}

		public static bool HasNullValue<TKey, TValue>(this Dictionary<TKey, TValue> dict)
		{
			return false;
		}

		public static T GetRandom<T>(this IList<T> list)
		{
			return default;
		}

		public static T GetRandom<T>(this ICollection<T> collection)
		{
			return default;
		}

		public static int GetRandomIndex<T>(this IList<T> list)
		{
			return 0;
		}

		public static List<T> PickRandom<T>(this IList<T> source, int count, System.Random random = null)
		{
			return null;
		}

		public static T PickRandom<T>(this IList<T> source, System.Random random)
		{
			return default;
		}

		public static IList<T> Shuffle<T>(this IList<T> list, System.Random random = null)
		{
			return null;
		}

		public static IEnumerable<T> Shuffled<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static T GetLast<T>(this IReadOnlyList<T> list)
		{
			return default;
		}

		public static T GetModIndex<T>(this IList<T> list, int index)
		{
			return default;
		}

		public static int GetMaxElementCount<T>(this IEnumerable<T> source, int desiredCount)
		{
			return 0;
		}

		public static bool SequenceEquals<T>(this IList<T> list1, IList<T> list2)
		{
			return false;
		}

		public static bool SetEquals<T>(this IList<T> list1, IList<T> list2)
		{
			return false;
		}

		public static List<T> Clone<T>(this List<T> list)
		{
			return null;
		}

		public static int[] GetIndicesForRow(int rowIndex, int itemsPerRow)
		{
			return null;
		}

		public static bool CheckIsNullOrEmpty<T>(this T[] collection)
		{
			return false;
		}

		public static bool CheckIsNullOrEmpty<T>(this List<T> collection)
		{
			return false;
		}

		public static bool CheckIsNullOrEmpty<T, TZ>(this Dictionary<T, TZ> collection)
		{
			return false;
		}

		public static bool CheckHaveItemNull<T>(this List<T> collection)
		{
			return false;
		}

		public static bool CheckHaveItemNull<T>(this T[] collection)
		{
			return false;
		}

		public static bool CheckHaveItemNull<T, TZ>(this Dictionary<T, TZ> collection)
		{
			return false;
		}

		public static bool Compare<T>(this List<T> list1, List<T> list2)
		{
			return false;
		}

		public static bool Compare<T>(this T[] list1, T[] list2)
		{
			return false;
		}

		public static T ToEnum<T>(this string value) where T : struct, Enum
		{
			return default;
		}

		public static bool IsValidEnum<T>(this string value) where T : struct, Enum
		{
			return false;
		}

		public static bool IsEnum<T>(this string value) where T : struct, Enum
		{
			return false;
		}

		public static Tweener ChangeText(this Text text, int start, int end, float duration)
		{
			return null;
		}

		public static Tweener ChangeText(this Text text, long start, long end, float duration, string format)
		{
			return null;
		}

		public static Tweener ChangeText(this TMP_Text text, int start, int end, float duration)
		{
			return null;
		}

		public static Tweener ChangeText(this TMP_Text text, float start, float end, float duration, string format)
		{
			return null;
		}

		public static Tweener ChangeText(this TMP_Text text, long start, long end, float duration, string format)
		{
			return null;
		}

		public static Tweener ChangeImageFill(this Image image, float start, float end, float duration)
		{
			return null;
		}

		public static Tweener ChangeImageWidth(this RectTransform rect, float endWidth, float duration)
		{
			return null;
		}

		public static bool HasUIElementAtMousePosition()
		{
			return false;
		}

		public static void SnapTo(this ScrollRect scroller, RectTransform child, float duration, float delay = 0f, Action onComplete = null)
		{
		}

		public static int SetFlag(this int value, int flagIndex)
		{
			return 0;
		}

		public static int ClearFlag(this int value, int flagIndex)
		{
			return 0;
		}

		public static bool HasFlag(this int value, int flagIndex)
		{
			return false;
		}

		public static long SetFlag(this long value, int flagIndex)
		{
			return 0L;
		}

		public static long ClearFlag(this long value, int flagIndex)
		{
			return 0L;
		}

		public static bool HasFlag(this long value, int flagIndex)
		{
			return false;
		}

		public static int RaiseFlag(int value, int flagIdx)
		{
			return 0;
		}

		public static int DownFlag(int value, int flagIdx)
		{
			return 0;
		}

		public static bool CheckFlag(int value, int flagIdx)
		{
			return false;
		}

		public static long RaiseFlagLong(long value, int flagIdx)
		{
			return 0L;
		}

		public static long DownFlagLong(long value, int flagIdx)
		{
			return 0L;
		}

		public static bool CheckFlagLong(long value, int flagIdx)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CWaitForCondition_003Ed__130))]
		public static IEnumerator WaitForCondition(Func<bool> condition, float requiredDuration)
		{
			return null;
		}

		public static IEnumerator WaitFor(Func<bool> action, float delay)
		{
			return null;
		}

		public static float GetRandomPercent()
		{
			return 0f;
		}

		public static bool IsAABBOverlap(Vector2 pos1, BoxCollider2D box1, Vector2 pos2, BoxCollider2D box2)
		{
			return false;
		}

		public static bool IsCollider(Vector2 pos1, BoxCollider2D box1, Vector2 pos2, BoxCollider2D box2)
		{
			return false;
		}

		public static void SetCurveLinear(this AnimationCurve curve)
		{
		}

		public static string ToRomanNumeral(this int value)
		{
			return null;
		}

		public static string GetRomanNumeralsForShipTier(int value)
		{
			return null;
		}
	}
}
