using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour


{
    public Animator animator;
    public float moveSpeed = 5f; // Speed of the movement

    void Update()
    {
        // Get horizontal and vertical input (A/D or Left/Right arrows for horizontal, W/S or Up/Down arrows for vertical)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0) * moveSpeed * Time.deltaTime;
        if (movement != Vector3.zero)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
            // Move the GameObject
            transform.position += movement;
    }
}