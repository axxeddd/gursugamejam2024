using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{   public Animator animator;
    public Canvas canvas;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SecondArm"))
        {
            animator.SetBool("SecondArm", true);
            canvas.enabled = true;

            StartCoroutine(DisableCanvas());
        }
    }

    private IEnumerator DisableCanvas() {
        yield return new WaitForSeconds(6f);
        canvas.enabled = false;
    }

}
