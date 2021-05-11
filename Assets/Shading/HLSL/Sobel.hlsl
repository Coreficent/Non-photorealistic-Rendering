#ifndef SOBEL_INCLUDED
#define SOBEL_INCLUDED

#include "UnityCG.cginc"

sampler2D _MainTex;
float _DeltaX;
float _DeltaY;


/*
* the sobel operator
*/
float sobel(sampler2D tex, float2 uv)
{
	float2 delta = float2(_DeltaX, _DeltaY);

	float4 gy = float4(0, 0, 0, 0);
	float4 gx = float4(0, 0, 0, 0);

	gy += tex2D(tex, (uv + float2(-1.0, -1.0) * delta)) * 1.0;
	gy += tex2D(tex, (uv + float2(0.0, -1.0) * delta)) * 2.0;
	gy += tex2D(tex, (uv + float2(1.0, -1.0) * delta)) * 1.0;
	gy += tex2D(tex, (uv + float2(-1.0, 0.0) * delta)) * 0.0;
	gy += tex2D(tex, (uv + float2(0.0, 0.0) * delta)) * 0.0;
	gy += tex2D(tex, (uv + float2(1.0, 0.0) * delta)) * 0.0;
	gy += tex2D(tex, (uv + float2(-1.0, 1.0) * delta)) * -1.0;
	gy += tex2D(tex, (uv + float2(0.0, 1.0) * delta)) * -2.0;
	gy += tex2D(tex, (uv + float2(1.0, 1.0) * delta)) * -1.0;

	gx += tex2D(tex, (uv + float2(-1.0, -1.0) * delta)) * 1.0;
	gx += tex2D(tex, (uv + float2(0.0, -1.0) * delta)) * 0.0;
	gx += tex2D(tex, (uv + float2(1.0, -1.0) * delta)) * -1.0;
	gx += tex2D(tex, (uv + float2(-1.0, 0.0) * delta)) * 2.0;
	gx += tex2D(tex, (uv + float2(0.0, 0.0) * delta)) * 0.0;
	gx += tex2D(tex, (uv + float2(1.0, 0.0) * delta)) * -2.0;
	gx += tex2D(tex, (uv + float2(-1.0, 1.0) * delta)) * 1.0;
	gx += tex2D(tex, (uv + float2(0.0, 1.0) * delta)) * 0.0;
	gx += tex2D(tex, (uv + float2(1.0, 1.0) * delta)) * -1.0;

	return sqrt(gx * gx + gy * gy);
}

float4 frag(v2f_img i) : COLOR
{
	float s = sobel(_MainTex, i.uv);
	fixed4 c = tex2D(_MainTex, i.uv);

	return c - float4(s, s, s, 1);
}

#endif
