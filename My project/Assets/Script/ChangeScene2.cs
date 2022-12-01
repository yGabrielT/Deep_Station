using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
     
    void OnTriggerEnter(Collider other)
    {
        ChageScene.troca = true;
    }
}
