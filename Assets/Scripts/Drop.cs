using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    #region Variables
    [SerializeField] private float deadline;
    private MeshRenderer renderer;
    private Rigidbody rb;
    #endregion
    private void Start()
    {
        //putting something in the cache
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        //using the cache
        renderer.enabled = false;
        rb.useGravity = false;
    }
    private void Update()
    {
        if(Time.time > deadline)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
