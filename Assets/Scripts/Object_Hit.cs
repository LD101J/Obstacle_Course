using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Hit : MonoBehaviour
{
    private void OnCollisionEnter(Collision teros)
    {
        Debug.Log("Wall_Hit");
    }
}
