using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    #region Variables
    [SerializeField] private int xValue;
    [SerializeField] private int yValue;
    [SerializeField] private int zValue;
    #endregion
    private void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
