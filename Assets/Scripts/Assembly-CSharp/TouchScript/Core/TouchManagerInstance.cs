using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TouchScript.Devices.Display;
using TouchScript.InputSources;
using TouchScript.Layers;
using TouchScript.Pointers;
using TouchScript.Utils;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

namespace TouchScript.Core
{
	public sealed class TouchManagerInstance : DebuggableMonoBehaviour, ITouchManager
	{
		[CompilerGenerated]
		private sealed class _003ClateAwake_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TouchManagerInstance _003C_003E4__this;

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
			public _003ClateAwake_003Ed__109(int _003C_003E1__state)
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

		private EventHandler<PointerEventArgs> pointersAddedInvoker;

		private EventHandler<PointerEventArgs> pointersUpdatedInvoker;

		private EventHandler<PointerEventArgs> pointersPressedInvoker;

		private EventHandler<PointerEventArgs> pointersReleasedInvoker;

		private EventHandler<PointerEventArgs> pointersRemovedInvoker;

		private EventHandler<PointerEventArgs> pointersCancelledInvoker;

		private EventHandler frameStartedInvoker;

		private EventHandler frameFinishedInvoker;

		private static bool shuttingDown;

		private static TouchManagerInstance instance;

		private bool shouldCreateCameraLayer;

		private bool shouldCreateStandardInput;

		private IDisplayDevice displayDevice;

		private float dpi;

		private float dotsPerCentimeter;

		private ILayerManager layerManager;

		private List<IInputSource> inputs;

		private int inputCount;

		private List<Pointer> pointers;

		private HashSet<Pointer> pressedPointers;

		private Dictionary<int, Pointer> idToPointer;

		private List<Pointer> pointersAdded;

		private HashSet<int> pointersUpdated;

		private HashSet<int> pointersPressed;

		private HashSet<int> pointersReleased;

		private HashSet<int> pointersRemoved;

		private HashSet<int> pointersCancelled;

		private static ObjectPool<List<Pointer>> pointerListPool;

		private static ObjectPool<List<int>> intListPool;

		private int nextPointerId;

		private object pointerLock;

		private Func<TouchLayer, bool> _layerAddPointer;

		private Func<TouchLayer, bool> _layerUpdatePointer;

		private Func<TouchLayer, bool> _layerRemovePointer;

		private Func<TouchLayer, bool> _layerCancelPointer;

		private Pointer tmpPointer;

		private CustomSampler samplerUpdateInputs;

		private CustomSampler samplerUpdateAdded;

		private CustomSampler samplerUpdatePressed;

		private CustomSampler samplerUpdateUpdated;

		private CustomSampler samplerUpdateReleased;

		private CustomSampler samplerUpdateRemoved;

		private CustomSampler samplerUpdateCancelled;

		public static TouchManagerInstance Instance => null;

		public IDisplayDevice DisplayDevice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float DPI => 0f;

		public bool ShouldCreateCameraLayer
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShouldCreateStandardInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IList<IInputSource> Inputs => null;

		public float DotsPerCentimeter => 0f;

		public int PointersCount => 0;

		public IList<Pointer> Pointers => null;

		public int PressedPointersCount => 0;

		public IList<Pointer> PressedPointers => null;

		public bool IsInsidePointerFrame { get; private set; }

		public event EventHandler FrameStarted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler FrameFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersAdded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersUpdated
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersPressed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersReleased
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersRemoved
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<PointerEventArgs> PointersCancelled
		{
			add
			{
			}
			remove
			{
			}
		}

		public bool AddInput(IInputSource input)
		{
			return false;
		}

		public bool RemoveInput(IInputSource input)
		{
			return false;
		}

		public void CancelPointer(int id, bool shouldReturn)
		{
		}

		public void CancelPointer(int id)
		{
		}

		public void UpdateResolution()
		{
		}

		internal void INTERNAL_AddPointer(Pointer pointer)
		{
		}

		internal void INTERNAL_UpdatePointer(int id)
		{
		}

		internal void INTERNAL_PressPointer(int id)
		{
		}

		internal void INTERNAL_ReleasePointer(int id)
		{
		}

		internal void INTERNAL_RemovePointer(int id)
		{
		}

		internal void INTERNAL_CancelPointer(int id)
		{
		}

		private void Awake()
		{
		}

		private void sceneLoadedHandler(Scene scene, LoadSceneMode mode)
		{
		}

		[IteratorStateMachine(typeof(_003ClateAwake_003Ed__109))]
		private IEnumerator lateAwake()
		{
			return null;
		}

		private void Update()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void createCameraLayer()
		{
		}

		private void createInput()
		{
		}

		private void updateInputs()
		{
		}

		private void updateAdded(List<Pointer> pointers)
		{
		}

		private bool layerAddPointer(TouchLayer layer)
		{
			return false;
		}

		private void updateUpdated(List<int> pointers)
		{
		}

		private bool layerUpdatePointer(TouchLayer layer)
		{
			return false;
		}

		private void updatePressed(List<int> pointers)
		{
		}

		private void updateReleased(List<int> pointers)
		{
		}

		private void updateRemoved(List<int> pointers)
		{
		}

		private bool layerRemovePointer(TouchLayer layer)
		{
			return false;
		}

		private void updateCancelled(List<int> pointers)
		{
		}

		private bool layerCancelPointer(TouchLayer layer)
		{
			return false;
		}

		private void sendFrameStartedToPointers()
		{
		}

		private void updatePointers()
		{
		}

		private bool wasPointerAddedThisFrame(int id, out Pointer pointer)
		{
			pointer = null;
			return false;
		}
	}
}
