using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    public int cena; 
     
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(cena);
    }
}
