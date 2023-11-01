Shader "Custom/EmissionDistanceShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _Emission ("Emission", Range(0, 1)) = 0
        _Distance ("Distance", Range(0, 10)) = 1
    }
 
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100
 
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
 
            uniform float4 _Color;
            uniform float _Emission;
            uniform float _Distance;
 
            struct appdata
            {
                float4 vertex : POSITION;
            };
 
            struct v2f
            {
                float4 vertex : SV_POSITION;
                float3 worldPos : TEXCOORD0;
            };
 
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target
            {
                float distance = length(i.worldPos - _WorldSpaceCameraPos);
                float3 color = _Color.rgb * (1 - _Emission * (distance / _Distance));
                return float4(color, _Color.a);
            }
            ENDCG
        }
    }
}
