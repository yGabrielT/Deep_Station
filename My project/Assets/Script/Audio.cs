using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public AudioSource um;
    public AudioSource dois;

    public void Audio1()
    {
        um.Play();
    }

    public void Audio2()
    {
        dois.Play();
    }

    public void TrocarCena()
    {
        SceneManager.LoadScene(3);
    }
}
