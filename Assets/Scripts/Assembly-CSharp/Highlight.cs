using System;
using TouchScript.Behaviors.UI;
using UnityEngine;

public class Highlight : MonoBehaviour
{
	public Color OverColor;

	private OverHelper over;

	private MeshRenderer r;

	private Material oldMaterial;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void overHandler(object sender, EventArgs e)
	{
	}

	private void outHandler(object sender, EventArgs e)
	{
	}
}
