using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float fldestroyDelay = 0.5f;
    bool bolhasPackage;

     void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Danger!");
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !bolhasPackage) 
        {
            Debug.Log("Package Picked Up");
            bolhasPackage = true;
            Destroy(other.gameObject, fldestroyDelay);
        }

        if (other.tag == "Customer" && bolhasPackage) 
        {
            Debug.Log("Package Delivered");
            bolhasPackage = false;

        }
    }

}
