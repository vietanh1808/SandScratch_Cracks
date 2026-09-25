using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SandBlower : ASandBlower
{
	public MMF_Player playFb;

	public MMF_Player stopFb;

	public ParticleSystem hutFx;

	public ParticleSystem dayFx;

	[Tooltip("Linework outline feature bật/tắt theo hiệu ứng conveyor — kéo feature outline (Soft/Wide/... ) từ renderer 'Linework Renderer - Ingame' vào đây. ActiveEffectConveyor -> SetActive(true); DeactiveEffectConveyor -> SetActive(false).")]
	[SerializeField]
	private List<ScriptableRendererFeature> conveyorOutlines;

	private bool isPlaying;

	public override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}

	public override void PlayDayFx()
	{
	}

	public override void StopFx()
	{
	}

	private void PlayHutFx()
	{
	}

	private void SwitchFx(ParticleSystem on, ParticleSystem off)
	{
	}

	private void RestartFx(ParticleSystem ps)
	{
	}

	public void ActiveEffectConveyor()
	{
	}

	public void DeactiveEffectConveyor()
	{
	}

	private void SetConveyorOutline(bool active)
	{
	}

	public void SetMagnetActive(bool active)
	{
	}
}
