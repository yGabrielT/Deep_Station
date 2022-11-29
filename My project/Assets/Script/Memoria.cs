using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Memoria : MonoBehaviour
{
    public GameObject Bt1;
    public GameObject Bt2;
    public GameObject Bt3;
    public GameObject Bt4;
    public AudioSource mp3;
    public AudioSource mp32;
    private float num = 0;


    public void Certo11()
    {
        if (num == 0)
        {
             num = num + 1;
             mp32.Play();
        }
        else
        {
            num = 0;
            mp3.Play();
        }

    }
    public void Erro12()
    {
        if (num == 1)
        {
            num = num + 1;
            mp32.Play();
        }
        else
        {
            num = 0;
            mp3.Play();
        }
    }
    public void Erro13()
    {

        if (num == 2)
        {
            num = num + 1;
            mp32.Play();
        }
        else
        {
            num = 0;
            mp3.Play();
        }
    }
    public void Erro14()
    {
        if (num == 3)
        {
            Bt1.SetActive(false);
            Bt2.SetActive(false);
            Bt3.SetActive(false);
            Bt4.SetActive(false);
            mp32.Play();
            SceneManager.LoadScene(8);
        }
        else
        {
            num = 0;
            mp3.Play();
        }
    }
}
