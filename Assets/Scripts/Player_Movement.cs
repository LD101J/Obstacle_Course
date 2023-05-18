using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    #region Variables
    [SerializeField] private float moveSpeed;
    
    #endregion
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;//local variable
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;//local variable

        transform.Translate(xValue, 0, zValue) ;
    }
}
