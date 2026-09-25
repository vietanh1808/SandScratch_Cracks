Shader "SandFlow/GrainInstanced3D" {
	Properties {
		_GrainScale ("Grain Size (visual, độc lập radiusScale)", Range(0.1, 2)) = 1
		_ColorBrightness ("Color Brightness (độ sáng màu hạt)", Range(0, 3)) = 1
		_LightDir ("Light Dir (screen-space)", Vector) = (-0.5,0.7,0.6,0)
		_Ambient ("Ambient (nền sáng đáy)", Range(0, 1)) = 0.35
		_SpecStrength ("Specular Strength (độ bóng highlight)", Range(0, 2)) = 0.6
		_SpecPower ("Specular Power (độ gọn highlight)", Range(1, 128)) = 48
		_RimStrength ("Rim Strength (viền khối, 0=tắt)", Range(0, 1)) = 0
		_BrightJitter ("Per-grain Brightness Jitter (sáng/tối mỗi hạt)", Range(0, 0.5)) = 0.15
		_GrainTilt ("Per-grain Normal Tilt (lệch khối mỗi hạt)", Range(0, 0.4)) = 0.15
		_GlintChance ("Glint Chance (tỉ lệ hạt lấp lánh)", Range(0, 1)) = 0.2
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
}