using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    // Start is called before the first frame update
    public void MudeCena()
    {
        SceneManager.LoadScene(7);
    }
}
