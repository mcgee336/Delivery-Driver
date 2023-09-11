using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float fltsteerSpeed = 1;
    float fltmoveSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, fltsteerSpeed);
        transform.Translate(0, fltmoveSpeed, 0);
    }
}
