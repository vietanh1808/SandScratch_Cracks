using Animancer;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(AnimancerComponent))]
public class QuickEditorAnimationController : MonoBehaviour
{
	[SerializeField]
	private AnimancerComponent animancer;

	[SerializeField]
	private AnimationClip idleClip;

	[SerializeField]
	private AnimationClip[] clips;

	[SerializeField]
	private int curClipIndex;

	[SerializeField]
	private AnimationClip clip;

	[Header("Blend Transition")]
	[SerializeField]
	private LinearMixerTransition mixerTransition;

	[Range(0f, 1f)]
	[SerializeField]
	private float blendProccess;

	private void OnValidate()
	{
	}

	private void Reset()
	{
	}

	private void PlayAnimation()
	{
	}

	private void PlayNextAnimation()
	{
	}

	private void PlayPreviousAnimation()
	{
	}

	private void OnBlendingTransition()
	{
	}
}
