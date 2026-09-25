using System;
using System.Collections.Generic;
using TouchScript.Devices.Display;
using TouchScript.InputSources;
using TouchScript.Pointers;

namespace TouchScript
{
	public interface ITouchManager
	{
		IDisplayDevice DisplayDevice { get; set; }

		float DPI { get; }

		bool ShouldCreateCameraLayer { get; set; }

		bool ShouldCreateStandardInput { get; set; }

		IList<IInputSource> Inputs { get; }

		float DotsPerCentimeter { get; }

		int PointersCount { get; }

		int PressedPointersCount { get; }

		IList<Pointer> Pointers { get; }

		IList<Pointer> PressedPointers { get; }

		bool IsInsidePointerFrame { get; }

		event EventHandler FrameStarted;

		event EventHandler FrameFinished;

		event EventHandler<PointerEventArgs> PointersAdded;

		event EventHandler<PointerEventArgs> PointersUpdated;

		event EventHandler<PointerEventArgs> PointersPressed;

		event EventHandler<PointerEventArgs> PointersReleased;

		event EventHandler<PointerEventArgs> PointersRemoved;

		event EventHandler<PointerEventArgs> PointersCancelled;

		bool AddInput(IInputSource input);

		bool RemoveInput(IInputSource input);

		void CancelPointer(int id, bool shouldReturn);

		void CancelPointer(int id);

		void UpdateResolution();
	}
}
