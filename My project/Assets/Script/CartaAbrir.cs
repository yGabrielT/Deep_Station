using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAbrir : MonoBehaviour
{
    private float Distance;
    public GameObject ACTexto;
    public GameObject CTexto;
    public GameObject Carta;
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
                    ACTexto.SetActive(true);
                    CTexto.SetActive(true);
                }
                else
                {
                    CTexto.SetActive(false);
                    ACTexto.SetActive(false);
                }
                if (Input.GetButtonDown("Action"))
                {
                    if (Distance <= 15)
                    {
                        this.GetComponent<BoxCollider>().enabled = false;
                        this.GetComponent<MeshRenderer>().enabled = false;
                        CTexto.SetActive(false);
                        ACTexto.SetActive(false);
                        Carta.SetActive(true);
                    }
                }
            }

        }
        else
        {
            CTexto.SetActive(false);
            ACTexto.SetActive(false);

        }

    }
    void Update()
    {
        Distance = PlayerCasting.DistanciaDoTrajeto;
        GetMouseInfo();
    }

}
