using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosProcessamento : MonoBehaviour
{
    public Material effect;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, effect);
    }
}
