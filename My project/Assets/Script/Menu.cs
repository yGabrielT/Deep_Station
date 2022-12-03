using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    public void BotaoIniciar()
    {
        SceneManager.LoadScene(0);
    }

    public void BotaoSair()
    {
        Application.Quit();
    }

    public void VoltarAoMenu()
    {
        ChageScene.troca = true;
    }
}
