using TouchScript.Core;
using TouchScript.Pointers;
using UnityEngine;

namespace TouchScript.InputSources
{
	public abstract class InputSource : MonoBehaviour, IInputSource, INTERNAL_IInputSource
	{
		[SerializeField]
		[HideInInspector]
		protected bool basicEditor;

		private ICoordinatesRemapper coordinatesRemapper;

		private TouchManagerInstance manager;

		public ICoordinatesRemapper CoordinatesRemapper
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool UpdateInput()
		{
			return false;
		}

		public virtual void UpdateResolution()
		{
		}

		public virtual bool CancelPointer(Pointer pointer, bool shouldReturn)
		{
			return false;
		}

		public virtual void INTERNAL_DiscardPointer(Pointer pointer)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void addPointer(Pointer pointer)
		{
		}

		protected virtual void updatePointer(Pointer pointer)
		{
		}

		protected virtual void pressPointer(Pointer pointer)
		{
		}

		protected virtual void releasePointer(Pointer pointer)
		{
		}

		protected virtual void removePointer(Pointer pointer)
		{
		}

		protected virtual void cancelPointer(Pointer pointer)
		{
		}

		protected virtual void updateCoordinatesRemapper(ICoordinatesRemapper remapper)
		{
		}

		protected virtual Vector2 remapCoordinates(Vector2 position)
		{
			return default;
		}
	}
}
