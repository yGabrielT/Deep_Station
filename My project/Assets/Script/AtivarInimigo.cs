using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarInimigo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        InimigoAI.eInimigo = true;
    }
}
