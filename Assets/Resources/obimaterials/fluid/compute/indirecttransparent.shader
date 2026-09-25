Shader "Shader Graphs/IndirectTransparent" {
	Properties {
		[NoScaleOffset] _Texture ("Texture", 2D) = "black" {}
		_Tiling ("Tiling", Float) = 0
		_TriplanarBlend ("TriplanarBlend", Float) = 0
		_Timescale ("Timescale", Float) = 0
		_DiffuseColor ("DiffuseColor", Vector) = (1,1,1,1)
		_Color ("Color", Vector) = (0,0,0,0)
		_Smoothness ("Smoothness", Range(0, 1)) = 0.8
		_Turbidity ("Turbidity", Vector) = (0,0,0,0)
		_Thickness ("Thickness", Float) = 3
		_Refraction ("Refraction", Float) = 0.05
		_SimulationTime ("SimulationTime", Float) = 0
		_Offset ("Offset", Float) = -0.5
		_NormalMapIntensity ("NormalMapIntensity", Float) = 0
		[NoScaleOffset] [Normal] _NormalMap ("NormalMap", 2D) = "bump" {}
		_NormalMapVelRange ("NormalMapVelRange", Vector) = (0,0,0,0)
		[NoScaleOffset] _ReflectionCubemap ("ReflectionCubemap", Cube) = "" {}
		_NoiseMapTiling ("NoiseMapTiling", Float) = 0
		_NoiseMapIntensity ("NoiseMapIntensity", Float) = 0
		[NoScaleOffset] _AdvectionNoise ("AdvectionNoise", 2D) = "white" {}
		_Jump ("Jump", Vector) = (0,0,0,0)
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[HideInInspector] _BUILTIN_QueueOffset ("Float", Float) = 0
		[HideInInspector] _BUILTIN_QueueControl ("Float", Float) = -1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}