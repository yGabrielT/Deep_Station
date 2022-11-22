using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuebraParede : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {     
        Destroy (gameObject);
    }
}