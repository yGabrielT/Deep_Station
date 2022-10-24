using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public GameObject aPorta;
    public GameObject Tranca;
    public AudioSource SomDaPorta;
    public float ChaveIsHere; 

    void Update()
    {
        aDistancia = PlayerCasting.DistanciaDoTrajeto;
        ChaveIsHere = PickKey.ChaveOpen;
    }

    void OnMouseOver()
    {
        if (aDistancia <= 15 && ChaveIsHere == 0)
        {
            Tranca.SetActive(true);
        }
        if (aDistancia <= 15 && ChaveIsHere == 1)
        {
            AcTexto.SetActive (true);
            DescTexto.SetActive (true);
        }
        if (Input.GetButtonDown("Action") && ChaveIsHere == 1)
        {
            if (aDistancia <= 15)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                DescTexto.SetActive(false);
                AcTexto.SetActive(false);
                aPorta.GetComponent<Animation>().Play("DoorOpen");
                SomDaPorta.Play();
            }
        }
    }
    void OnMouseExit()
    {
        DescTexto.SetActive(false);
        AcTexto.SetActive(false);
        Tranca.SetActive(false);
    }
}
