using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collides with the collectible
        if (collision.gameObject.CompareTag("Player"))
        {
            // Optionally, you can add logic to increase score or inventory here
            Debug.Log("Collected!");

            // Destroy the collectible object
            Destroy(gameObject);
        }
    }
}
