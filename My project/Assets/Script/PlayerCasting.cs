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
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100, Color.green);

        if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out Hit))
        {
            oTrajeto = Hit.distance;
            DistanciaDoTrajeto = oTrajeto;
        }
    }
}
