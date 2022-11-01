using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public float Distance;
    public GameObject ATexto;
    public GameObject DTexto;
    public static float ChaveOpen = 0;
    public Camera cam;

    void GetMouseInfo()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.transform.name == name)
            {
                if (Distance <= 15)
                {
                    ATexto.SetActive(true);
                    DTexto.SetActive(true);
                }
                else
                {
                    DTexto.SetActive(false);
                    ATexto.SetActive(false);
                }
                if (Input.GetButtonDown("Action"))
                {
                    if (Distance <= 15)
                    {
                        this.GetComponent<BoxCollider>().enabled = false;
                        this.GetComponent<MeshRenderer>().enabled = false;
                        ChaveOpen = 1;
                    }
                }
            }

        }
        else
        {
            DTexto.SetActive(false);
            ATexto.SetActive(false);

        }

    }
    void Update()
    {
        Distance = PlayerCasting.DistanciaDoTrajeto;
        GetMouseInfo();
    }
}
