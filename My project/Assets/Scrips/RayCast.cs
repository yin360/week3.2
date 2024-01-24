using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    void Update()
    {
        Debug.DrawRay(shootPoint.transform.position, transform.TransformDirection(Vector3.forward)* 20, Color.green);
        if (Physics.Raycast(shootPoint.transform.position,
                transform.TransformDirection(Vector3.forward),
                out RaycastHit hitInfo, 20f))
        {
            if (hitInfo.collider.tag == "star")
            {
                Debug.Log($"Hit {hitInfo.collider.gameObject.tag}");
                Debug.DrawRay(shootPoint.transform.position, transform.TransformDirection(Vector3.forward ) * 20, Color.red);
                hitInfo.transform.GetComponent<Renderer>().material.color = Color.red;
                hitInfo.transform.GetComponent<Rigidbody>().useGravity = true; 

            }
        }
        
        
    }
}
