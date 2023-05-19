using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision teros)
    { 
        
        if(teros.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            gameObject.tag = "Hit";
        }
    }
}
