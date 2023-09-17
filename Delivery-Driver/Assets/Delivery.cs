using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool bolhasPackage;

     void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Danger!");
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package") 
        {
            Debug.Log("Package Picked Up");
            bolhasPackage = true;
        }

        if (other.tag == "Customer" && bolhasPackage) 
        {
            Debug.Log("Package Delivered");
            bolhasPackage = false;

        }
    }

}
