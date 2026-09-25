using System;
using System.Collections.Generic;

namespace TouchScript.Utils
{
	internal sealed class TimedSequence<T>
	{
		private List<T> points;

		private List<float> timestamps;

		public void Add(T element)
		{
		}

		public void Add(T element, float time)
		{
		}

		public void Clear()
		{
		}

		public IList<T> FindElementsLaterThan(float time)
		{
			return null;
		}

		public IList<T> FindElementsLaterThan(float time, out float lastTime)
		{
			lastTime = default;
			return null;
		}

		public IList<T> FindElementsLaterThan(float time, Predicate<T> predicate)
		{
			return null;
		}
	}
}
