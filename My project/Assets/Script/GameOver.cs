using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Reiniciar()
    {
        SceneManager.LoadScene(3);
    }

    public void LiberarMouse()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
}
