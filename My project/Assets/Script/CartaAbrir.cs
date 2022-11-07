using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAbrir : MonoBehaviour
{
    private float Distance;
    public GameObject ACTexto;
    public GameObject CTexto;
    public GameObject Carta;
    public GameObject Volte;

    void OnMouseOver()
    {
        if (Distance <= 15)
        {
            ACTexto.SetActive(true);
            CTexto.SetActive(true);
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
                Volte.SetActive(true);
            }
        }
    }
    public void OnMouseExit()
    {
        CTexto.SetActive(false);
        ACTexto.SetActive(false);
    }
    void Update()
    {
        Distance = PlayerCasting.DistanciaDoTrajeto;
        if (Input.GetButtonDown("Voltar") && Carta.activeSelf)
        {
            Carta.SetActive(false);
            Volte.SetActive(false);
            this.GetComponent<BoxCollider>().enabled = true;
            this.GetComponent<MeshRenderer>().enabled = true;
        }
    }

}
