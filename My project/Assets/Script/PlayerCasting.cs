using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    public static float DistanciaDoTrajeto;
    public float oTrajeto;

    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Hit))
        {
            oTrajeto = Hit.distance;
            DistanciaDoTrajeto = oTrajeto;
        }
    }
}
