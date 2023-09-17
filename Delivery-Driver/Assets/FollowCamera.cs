using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objthingToFollow;
    
    // This cameras position should be the same as the car

    void LateUpdate()
    {
        transform.position = objthingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
