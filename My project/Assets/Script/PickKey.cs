using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public float Distance;
    public GameObject ATexto;
    public GameObject DTexto;
    public static float ChaveOpen = 0;

    void Update()
    {
        Distance = PlayerCasting.DistanciaDoTrajeto;
    }
    void OnMouseOver()
    {
        if (Distance <= 50)
        {
            ATexto.SetActive(true);
            DTexto.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 50)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                this.GetComponent<MeshRenderer>().enabled = false;
                ChaveOpen = 1;
            }
        }
    }
    void OnMouseExit()
    {
        DTexto.SetActive(false);
        ATexto.SetActive(false);
    }
}
