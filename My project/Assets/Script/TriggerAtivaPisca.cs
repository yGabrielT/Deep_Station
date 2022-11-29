using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAtivaPisca : MonoBehaviour
{
    public GameObject luzpisca;
    void OnTriggerEnter(Collider other)
    {
        luzpisca.SetActive(true);
    }
}
