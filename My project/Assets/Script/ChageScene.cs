using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChageScene : MonoBehaviour
{
    public int CarregarFase;
    public Animator animador;
    public int QualCena;
    public static bool troca;

    public void MudarParaNivel (int NivelIndex)
    {
        CarregarFase = NivelIndex;
        animador.SetTrigger("EntrarCena");
    }

    public void MudeCenaAnimador()
    {
        SceneManager.LoadScene(CarregarFase);
    }

    public void OnTriggerEnter(Collider other)
    {
        MudarParaNivel(QualCena);
    }

    public void Update()
    {
        if (troca == true)
        {
            MudarParaNivel(QualCena);
            troca = false;
        }
    }
    
  
}
