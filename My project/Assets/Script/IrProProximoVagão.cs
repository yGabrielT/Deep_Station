using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrProProximoVagão : MonoBehaviour
{
    private float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;


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

                    DescTexto.SetActive(false);
                    AcTexto.SetActive(false);
                    ChageScene.troca = true;
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
