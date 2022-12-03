using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public AudioSource um;
    public AudioSource dois;
    public AudioSource tres;
    public AudioSource quatro;

    public void Audio1()
    {
        um.Play();
    }

    public void Audio2()
    {
        dois.Play();
    }

    public void Audio3()
    {
        tres.Play();
    }

    public void PareAudio3()
    {
        tres.Stop();
    }
    
    public void Audio4()
    {
        quatro.Play();
    }

    public void TrocarCena()
    {
        ChageScene.troca = true;
    }
}
