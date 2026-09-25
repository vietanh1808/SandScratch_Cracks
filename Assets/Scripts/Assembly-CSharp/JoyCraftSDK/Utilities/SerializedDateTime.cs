using System;
using UnityEngine;

namespace JoyCraftSDK.Utilities
{
	[Serializable]
	public class SerializedDateTime : ISerializationCallbackReceiver, IComparable, IComparable<DateTime>, IEquatable<DateTime>, IFormattable
	{
		[HideInInspector]
		public DateTime dateTime;

		[SerializeField]
		private string _dateTime;

		public override string ToString()
		{
			return null;
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public static implicit operator DateTime(SerializedDateTime udt)
		{
			return default;
		}

		public static implicit operator SerializedDateTime(DateTime dt)
		{
			return null;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(DateTime other)
		{
			return 0;
		}

		public bool Equals(DateTime other)
		{
			return false;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public static bool operator ==(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator !=(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator <(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator >(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator <=(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator >=(SerializedDateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator ==(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator !=(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator <(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator >(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator <=(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator >=(SerializedDateTime left, DateTime right)
		{
			return false;
		}

		public static bool operator ==(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator !=(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator <(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator >(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator <=(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static bool operator >=(DateTime left, SerializedDateTime right)
		{
			return false;
		}

		public static SerializedDateTime operator +(SerializedDateTime dt, TimeSpan ts)
		{
			return null;
		}

		public static SerializedDateTime operator -(SerializedDateTime dt, TimeSpan ts)
		{
			return null;
		}

		public static TimeSpan operator -(SerializedDateTime dt1, SerializedDateTime dt2)
		{
			return default;
		}

		public static TimeSpan operator -(SerializedDateTime left, DateTime right)
		{
			return default;
		}

		public static TimeSpan operator -(DateTime left, SerializedDateTime right)
		{
			return default;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
