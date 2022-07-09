using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{
   [SerializeField] private float rotationSpeed=20;
    private float moveX;
    
    private void Update()
    {
        RotateCylinder();
    }
    private void RotateCylinder()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, rotationSpeed * moveX * Time.deltaTime, 0);
        }       
    }    
}
