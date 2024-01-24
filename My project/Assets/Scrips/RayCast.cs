using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward * 20), Color.green); 
        Vector3 diraction = Vector3.forward;
        if (Physics.Raycast(shootPoint.transform.position,
                transform.TransformDirection(Vector3.forward),
                out RaycastHit hitInfo, 20f))
        {
           
        }
        
        
    }
}
