using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 clrhasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 clrnoPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float fldestroyDelay = 0.5f;
    bool bolhasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }


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
            spriteRenderer.color = clrhasPackageColor;
        }

        if (other.tag == "Customer" && bolhasPackage) 
        {
            Debug.Log("Package Delivered");
            bolhasPackage = false;
            spriteRenderer.color = clrnoPackageColor;
        }
    }

}
