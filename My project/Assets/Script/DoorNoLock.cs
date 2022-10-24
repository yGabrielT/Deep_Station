using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorNoLock : MonoBehaviour
{
    public float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public GameObject aPorta;
    public AudioSource SomDaPorta;

    void Update()
    {
        aDistancia = PlayerCasting.DistanciaDoTrajeto;
    }

    void OnMouseOver()
    {
        if (aDistancia <= 15)
        {
            AcTexto.SetActive(true);
            DescTexto.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (aDistancia <= 15)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                DescTexto.SetActive(false);
                AcTexto.SetActive(false);
                aPorta.GetComponent<Animation>().Play("DoorOpen2");
                SomDaPorta.Play();
            }
        }
    }
    void OnMouseExit()
    {
        DescTexto.SetActive(false);
        AcTexto.SetActive(false);
    }
}

