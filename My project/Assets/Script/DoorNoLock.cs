using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorNoLock : MonoBehaviour
{
    private float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public GameObject aPorta;
    public AudioSource SomDaPorta;
    public Camera cam;

    void GetMouseInfo()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.transform.name == name)
            {
                if (aDistancia <= 15)
                {
                    AcTexto.SetActive(true);
                    DescTexto.SetActive(true);

                    if (Input.GetButtonDown("Action"))
                    {
                        if (aDistancia <= 15)
                        {
                            this.GetComponent<BoxCollider>().enabled = false;
                            DescTexto.SetActive(false);
                            AcTexto.SetActive(false);
                            aPorta.GetComponent<Animation>().Play("Door");
                            SomDaPorta.Play();
                        }
                    }
                }

            }

        }
        else
        {
            DescTexto.SetActive(false);
            AcTexto.SetActive(false);
        }

    }
    void Update()
    {
        aDistancia = PlayerCasting.DistanciaDoTrajeto;
        GetMouseInfo();
    }
}

