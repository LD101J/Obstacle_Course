using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    #region Variables
    private int hitPoints;
    #endregion
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            hitPoints++;
            Debug.Log("You have bumped into something this many times:  " + hitPoints);
        }
    }
}
