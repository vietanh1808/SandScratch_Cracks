Shader "JoyCraft/UI/PopupAnimatedGradient" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		[Header(Animated Darken Blob)] _Intensity ("Darken Intensity", Range(0, 1)) = 0.85
		_NoiseScale ("Noise Scale (blob to hon khi nho)", Range(0.3, 6)) = 0.8
		_Speed ("Drift Speed", Range(0.01, 3)) = 0.8
		_Threshold ("Threshold", Range(0, 1)) = 0.45
		_Softness ("Softness", Range(0.05, 1)) = 0.3
		[KeywordEnum(Darken, Cycle)] _BlobMode ("Blob Mode", Float) = 0
		_Color1 ("Cycle Color 1", Vector) = (1,0.3,0.3,1)
		_Color2 ("Cycle Color 2", Vector) = (0.3,0.6,1,1)
		_Color3 ("Cycle Color 3", Vector) = (1,0.85,0.2,1)
		_Color4 ("Cycle Color 4", Vector) = (0.4,1,0.5,1)
		[IntRange] _ColorCount ("Color Count", Range(1, 4)) = 3
		_CycleDuration ("Seconds Per Color", Range(0.2, 10)) = 2
		_CycleBlend ("Transition Ratio", Range(0.05, 1)) = 0.5
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
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
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	//CustomEditor "JoyCraftSDK.Editor.UIPopupAnimatedGradientShaderGUI"
}