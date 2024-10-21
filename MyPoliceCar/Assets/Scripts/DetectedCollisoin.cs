using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedCollisoin : MonoBehaviour
{
    public float force = 100f;
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("OnCollisionEnter");
        if (other.gameObject.tag == "Cube")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddRelativeForce(Vector3.up * force);
                Vector3 forceDir = transform.position - other.transform.position;
                forceDir.Normalize();
                
                rb.AddRelativeForce(-forceDir * force);
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {
            Debug.Log("OnCollisionStay");
        if (other.gameObject.tag == "Cube")
        {
        }
    }
}
