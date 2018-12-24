Shader "Unlit/Eye"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
	    _MainColor("Color",Color) = (1,1,1,1)
		_MainColor2("Color2",Color) = (1,1,1,1)
		_Blink("Blink",Range(0,0.5)) = 0.5
	}
	SubShader
	{
		Tags { "RenderType"="Transparent" }
		LOD 100
		Blend SrcAlpha OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			
			v2f vert (appdata v)
			{
				v2f o;
				//v.vertex.y *= (sin(_Time.z) + 1) * 0.5;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}



			float4 _MainColor;
			float4 _MainColor2;
			float _Blink;
			
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				i.uv.y -= 0.5;
			   // i.uv.y = i.uv.y * _Blink;
			if (abs(i.uv.y) > _Blink) {
				if (abs(i.uv.y) < _Blink + 0.01) {
					return _MainColor2;
				}
				else {
					return _MainColor;
				}
			}
			    i.uv.y += 0.5;


				fixed4 col = tex2D(_MainTex, i.uv);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);

				if (col.a < 0.1) {
					return (1, 1, 1, 1);
				}
				return col;
			}



			ENDCG
		}
	}
}
