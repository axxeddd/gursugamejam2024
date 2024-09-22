using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public Transform target; // The object to follow
    public float zOffset = -10f; // Camera's z position for 2D

    void LateUpdate()
    {
        // Set the camera's position to the target's position with the z offset
        transform.position = new Vector3(target.position.x, target.position.y, zOffset);
    }


}