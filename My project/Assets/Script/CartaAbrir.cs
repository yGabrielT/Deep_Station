using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartaAbrir : MonoBehaviour
{
    private float Distance;
    public GameObject ACTexto;
    public GameObject CTexto;
    public GameObject Carta;
    public GameObject Legend;
    public GameObject Volte;
    public GameObject obj;
    private Color startcolor;

    void OnMouseOver()
    {
        if (Distance <= 40)
        {
            ACTexto.SetActive(true);
            CTexto.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (Distance <= 40)
            {
                obj.GetComponent<BoxCollider>().enabled = false;
                obj.GetComponent<MeshRenderer>().enabled = false;
                CTexto.SetActive(false);
                ACTexto.SetActive(false);
                Carta.SetActive(true);
                Volte.SetActive(true);
                obj.GetComponent<Outline>().enabled = false;
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
            obj.GetComponent<BoxCollider>().enabled = true;
            obj.GetComponent<MeshRenderer>().enabled = true;
            Legend.GetComponent<Animation>().Play("Legend");
        }
    }

}
