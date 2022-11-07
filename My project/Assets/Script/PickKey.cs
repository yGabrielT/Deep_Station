using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    private float Distance;
    public GameObject ATexto;
    public GameObject DTexto;
    public static float ChaveOpen = 0;

    void OnMouseOver()
    {
        if (Distance <= 15)
        {
            ATexto.SetActive(true);
            DTexto.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 15)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                this.GetComponent<MeshRenderer>().enabled = false;
                ChaveOpen = 1;
                DTexto.SetActive(false);
                ATexto.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        DTexto.SetActive(false);
        ATexto.SetActive(false);
    }

    void Update()
    {
        Distance = PlayerCasting.DistanciaDoTrajeto;
    }
}
