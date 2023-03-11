#ifndef INDIRECT_RENDERING_CORE_INCLUDED
#if defined(UNITY_PROCEDURAL_INSTANCING_ENABLED)
#define INDIRECT_RENDERING_CORE_INCLUDED

#include "IndirectRenderingParams.hlsl"

    StructuredBuffer<IndirectRenderingParams> renderingParamsBuffer;

    inline void IndirectRenderingSetup()
    {
        unity_ObjectToWorld = renderingParamsBuffer[unity_InstanceID].objectToWorld;
        unity_WorldToObject = renderingParamsBuffer[unity_InstanceID].worldToObject;
        float lodFade = renderingParamsBuffer[unity_InstanceID].lodFade;
        unity_LODFade = float4(lodFade, lodFade, 0, 0);
    }

#define INDIRECT_RENDERING_PARAMS renderingParamsBuffer[unity_InstanceID]
#endif
#endif
