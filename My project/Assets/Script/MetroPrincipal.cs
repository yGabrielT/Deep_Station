using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetroPrincipal : MonoBehaviour
{
    public static float tcollider = 1;


    public void DesligarCollider()
    {
        tcollider = 1;
    }

    public void LigarCollider()
    {
        tcollider = 2;
    }
}
