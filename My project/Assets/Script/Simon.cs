using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Simon : MonoBehaviour
{
    private float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public GameObject aPorta;
    public GameObject Bt1;
    public GameObject Bt2;
    public GameObject Bt3;
    public GameObject Bt4;
    public GameObject Cm;

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
                    Bt1.SetActive(true);
                    Bt2.SetActive(true);
                    Bt3.SetActive(true);
                    Bt4.SetActive(true);
                    Cursor.lockState = CursorLockMode.Confined;
                    Cm.GetComponent<MouseLook>().enabled = false;
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
