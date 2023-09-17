using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltsteerSpeed = 0.1f;
    [SerializeField] float fltmoveSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fltsteerAmount = UnityEngine.Input.GetAxis("Horizontal") * fltsteerSpeed * Time.deltaTime;
        float fltmoveAmount = UnityEngine.Input.GetAxis("Vertical") * fltmoveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -fltsteerAmount);
        transform.Translate(0, fltmoveAmount, 0);
    }
}
