using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headbob : MonoBehaviour
{
    public Animator camAnin;
    public bool SprintToggle = false;


    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            camAnin.ResetTrigger("Crouch");
            camAnin.ResetTrigger("Idle");
            camAnin.ResetTrigger("Sprint");
            camAnin.SetTrigger("Walk");
            SprintToggle = false;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                camAnin.ResetTrigger("Crouch");
                camAnin.ResetTrigger("Idle");
                camAnin.ResetTrigger("Walk");
                camAnin.SetTrigger("Sprint");
                SprintToggle = true;
            }

            if (Input.GetKey(KeyCode.LeftControl) && SprintToggle == false)
            {
                camAnin.ResetTrigger("Idle");
                camAnin.ResetTrigger("Walk");
                camAnin.ResetTrigger("Sprint");
                camAnin.SetTrigger("Crouch");
                SprintToggle = false;
            }
        }

        else
        {
            camAnin.ResetTrigger("Crouch");
            camAnin.ResetTrigger("Walk");
            camAnin.ResetTrigger("Sprint");
            camAnin.SetTrigger("Idle");
            SprintToggle = false;
        }
    }
}
