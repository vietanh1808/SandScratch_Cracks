using System;
using JoyCraftSDK.Utilities;
using Sigtrap.Relays;
using UnityEngine;

namespace JoyCraftSDK.ToolBox
{
	[Serializable]
	public abstract class ATimer : JBase
	{
		[HideInInspector]
		public Relay<ATimer> OnTimerStarted;

		[HideInInspector]
		public Relay<ATimer> OnTimerPaused;

		[HideInInspector]
		public Relay<ATimer> OnTimerResumed;

		[HideInInspector]
		public Relay<ATimer> OnTimerReset;

		[HideInInspector]
		public Relay<ATimer> OnTimerUpdate;

		[HideInInspector]
		public Relay<ATimer> OnTimerFinished;

		public TimerState State { get; protected set; }

		public float SecondsLeft { get; protected set; }

		public float TimeSpent => 0f;

		public float Duration { get; protected set; }

		public float ProgressElapsed => 0f;

		public float ProgressLeft => 0f;

		public bool IsRunning => false;

		public bool IsPaused => false;

		public bool IsFinished => false;

		public bool IsIdle => false;

		public abstract void Init(float durationInSeconds);

		public abstract void Start();

		public virtual void Start(float durationInSeconds)
		{
		}

		public abstract void Restart();

		public abstract void Pause();

		public abstract void Resume();

		public abstract void Reset();

		public abstract void AddTime(float seconds);

		public abstract void MinusTime(float seconds);
	}
}
