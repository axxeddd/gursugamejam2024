using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("spike"))
        {
            RestartLevel();
        }
    }

    void RestartLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
