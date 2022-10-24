using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InimigoAI : MonoBehaviour
{

    public GameObject inimigoDest;
    NavMeshAgent inimigoAgent;
    public GameObject InimigoLocal;
    public static bool eInimigo;

    void Start()
    {
        inimigoAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (eInimigo == false)
        {
           // Código para animação
           // InimigoLocal.GetComponent<Animator>().Play("Idle");
        }
        else
        {
            // Código para animação
            // InimigoLocal.GetComponent<Animator>().Play("Walk");
            inimigoAgent.SetDestination(inimigoDest.transform.position);
        }
    }
}
