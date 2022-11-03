using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DoorOpen : MonoBehaviour
{
    private float aDistancia;
    public GameObject AcTexto;
    public GameObject DescTexto;
    public GameObject aPorta;
    public GameObject Tranca;
    public AudioSource SomDaPorta;
    public AudioSource SomTrancado;
    public float ChaveIsHere;
    public Camera cam;

    void GetMouseInfo()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.transform.name == name)
            {
                if (aDistancia <= 15 && ChaveIsHere == 0)
                {
                    AcTexto.SetActive(true);
                    DescTexto.SetActive(true);

                    if (Input.GetButtonDown("Action") && ChaveIsHere == 0)
                    {
                        if (aDistancia <= 15)
                        {
                            DescTexto.GetComponent<TextMeshProUGUI>().enabled = false;
                            AcTexto.GetComponent<TextMeshProUGUI>().enabled = false;
                            AcTexto.SetActive(false);
                            DescTexto.SetActive(false);
                            Tranca.SetActive(true);
                            SomTrancado.Play();
                        }
                    }
                }
                else
                {
                    DescTexto.SetActive(false);
                    AcTexto.SetActive(false);
                    Tranca.SetActive(false);
                }
                if (aDistancia <= 15 && ChaveIsHere == 1)
                {
                    AcTexto.SetActive(true);
                    DescTexto.SetActive(true);
                    DescTexto.GetComponent<TextMeshProUGUI>().enabled = true;
                    AcTexto.GetComponent<TextMeshProUGUI>().enabled = true;

                    if (Input.GetButtonDown("Action") && ChaveIsHere == 1)
                    {
                        if (aDistancia <= 15)
                        {
                            this.GetComponent<BoxCollider>().enabled = false;
                            DescTexto.SetActive(false);
                            AcTexto.SetActive(false);
                            aPorta.GetComponent<Animation>().Play("DoorNow");
                            SomDaPorta.Play();
                            ChaveIsHere = 0;
                        }
                    }
                }
            }

        }
        else
        {
            DescTexto.SetActive(false);
            AcTexto.SetActive(false);
            Tranca.SetActive(false);
        }

    }
    void Update()
    {
        aDistancia = PlayerCasting.DistanciaDoTrajeto;
        ChaveIsHere = PickKey.ChaveOpen;
        GetMouseInfo();
    }
}
