using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarMetro : MonoBehaviour
{
    private float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public float collision;


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
        collision = MetroPrincipal.tcollider;

        if (collision == 1)
        {
            this.GetComponent<BoxCollider>().enabled = false;
        }
        if (collision == 2)
        {
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }




}
