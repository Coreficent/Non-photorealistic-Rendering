Shader "Coreficent/Sobel" {

	Properties
	{
		_MainTex("Base (RGB)", 2D) = "white" {}
		_DeltaX("Delta X", Float) = 0.01
		_DeltaY("Delta Y", Float) = 0.01
	}

	SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		CGINCLUDE

		#include "../HLSL/Sobel.hlsl"

		ENDCG

		Pass {
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			ENDCG
		}

	}

	FallBack "Diffuse"
}
