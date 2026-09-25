using UnityEngine;

namespace Obi
{
	[RequireComponent(typeof(ObiCharacter))]
	public class SampleCharacterController : MonoBehaviour
	{
		private ObiCharacter m_Character;

		private Transform m_Cam;

		private Vector3 m_CamForward;

		private Vector3 m_Move;

		private bool m_Jump;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
