Shader "Unlit/PosProcessamenroPixel"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _pixels("Resolution", int) = 512
        _pw("Pixel Width", float) = 64
        _ph("Pixel Height", float) = 64
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

            float _pixels;
            float _pw;
            float _ph;
            float _dx;
            float _dy;
            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                _dx = _pw * (1 / _pixels);
                _dy = _ph * (1 / _pixels);
                float2 coord = float2(_dx * floor(i.uv.x / _dx), _dy * floor(i.uv.y / _dy));

                // sample the texture
                fixed4 col = tex2D(_MainTex, coord);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
