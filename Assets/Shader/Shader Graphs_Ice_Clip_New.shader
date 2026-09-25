Shader "Shader Graphs/Ice_Clip_New" {
	Properties {
		_BaseMap ("_BaseMap", 2D) = "white" {}
		_BaseColor ("_BaseColor", Vector) = (1,1,1,1)
		_ClipWorldY ("ClipWorldY", Float) = 2
		_Progress ("Progress", Range(0, 2)) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		[HDR] _MaskColor ("MaskColor", Vector) = (11.98431,11.98431,11.98431,0)
		[ToggleUI] _IsCircle ("IsCircle", Float) = 1
		_Outline_Width ("Outline_Width", Float) = 1
		_Rect_Tile ("Rect_Tile", Float) = 1
		_Density ("Density", Float) = 10
		_Offset ("Offset", Vector) = (0,0,0,0)
		[NoScaleOffset] _SampleTexture2D_d1bd8b4b14ba42568b82905d31cb21cc_Texture_1_Texture2D ("Texture2D", 2D) = "white" {}
		[NoScaleOffset] _SampleTexture2D_4bfb34e7a8d24f0092f0b215b0f7e1df_Texture_1_Texture2D ("Texture2D", 2D) = "white" {}
		[NoScaleOffset] _SampleTexture2D_857dcf37b1e94a05ac5586d5d3741cd8_Texture_1_Texture2D ("Texture2D", 2D) = "white" {}
		[NoScaleOffset] _SampleTexture2D_798a84a47c8d4cf4bf3a24298dd8ad02_Texture_1_Texture2D ("Texture2D", 2D) = "white" {}
		[HideInInspector] _CastShadows ("_CastShadows", Float) = 1
		[HideInInspector] _Surface ("_Surface", Float) = 0
		[HideInInspector] _Blend ("_Blend", Float) = 2
		[HideInInspector] _AlphaClip ("_AlphaClip", Float) = 1
		[HideInInspector] _SrcBlend ("_SrcBlend", Float) = 1
		[HideInInspector] _DstBlend ("_DstBlend", Float) = 0
		[HideInInspector] _SrcBlendAlpha ("_SrcBlendAlpha", Float) = 1
		[HideInInspector] _DstBlendAlpha ("_DstBlendAlpha", Float) = 0
		[ToggleUI] [HideInInspector] _ZWrite ("_ZWrite", Float) = 1
		[HideInInspector] _ZWriteControl ("_ZWriteControl", Float) = 0
		[HideInInspector] _ZTest ("_ZTest", Float) = 4
		[HideInInspector] _Cull ("_Cull", Float) = 2
		[HideInInspector] _AlphaToMask ("_AlphaToMask", Float) = 1
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
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

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}