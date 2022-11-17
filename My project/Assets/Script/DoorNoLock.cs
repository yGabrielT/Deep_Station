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

    void OnMouseOver()
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
                    aPorta.GetComponent<Animation>().Play("DoorOpening");
                    SomDaPorta.Play();
                }
            }
        }
    }
    void OnMouseExit()
    {
        DescTexto.SetActive(false);
        AcTexto.SetActive(false);
    }
    void Update()
    {
        aDistancia = PlayerCasting.DistanciaDoTrajeto;
    }
}

