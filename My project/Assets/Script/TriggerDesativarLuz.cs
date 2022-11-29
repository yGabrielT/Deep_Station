using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDesativarLuz : MonoBehaviour
{
    public GameObject luznormal;
    void OnTriggerEnter(Collider other)
    {
        luznormal.SetActive(false);
    }
}
