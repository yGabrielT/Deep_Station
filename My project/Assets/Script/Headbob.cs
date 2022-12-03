using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headbob : MonoBehaviour
{
    public Animator camAnin;
    public Animator PersonagemAnin;
    public bool SprintToggle = false;


    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            camAnin.ResetTrigger("Idle");
            camAnin.ResetTrigger("Sprint");
            camAnin.SetTrigger("Walk");
            PersonagemAnin.ResetTrigger("Idle");
            PersonagemAnin.ResetTrigger("Sprint");
            PersonagemAnin.SetTrigger("Walk");
            
            SprintToggle = false;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                camAnin.ResetTrigger("Idle");
                camAnin.ResetTrigger("Walk");
                camAnin.SetTrigger("Sprint");
                PersonagemAnin.ResetTrigger("Idle");
                PersonagemAnin.ResetTrigger("Walk");
                PersonagemAnin.SetTrigger("Sprint");
                SprintToggle = true;
            }
        }

        else
        {
            camAnin.ResetTrigger("Walk");
            camAnin.ResetTrigger("Sprint");
            camAnin.SetTrigger("Idle");
            PersonagemAnin.ResetTrigger("Sprint");
            PersonagemAnin.ResetTrigger("Walk");
            PersonagemAnin.SetTrigger("Idle");
            SprintToggle = false;
        }
    }
}
