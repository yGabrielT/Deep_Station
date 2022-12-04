using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPassos : MonoBehaviour
{
    public AudioSource footsteps, sprintsteps;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                sprintsteps.enabled = false;
                footsteps.enabled = false;
            }
            else
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    sprintsteps.enabled = true;
                    footsteps.enabled = false;
                }
                else
                {
                    footsteps.enabled = true;
                    sprintsteps.enabled = false;
                }
            }
        }
        else
        {
            footsteps.enabled = false;
            sprintsteps.enabled = false;
        }
    }
}
