using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtitleTimer : MonoBehaviour
{
    public GameObject subtitle;

    private void Start()
    {
        StartCoroutine(subtitleTimer());
    }
    private IEnumerator subtitleTimer()
    {
        yield return new WaitForSeconds(2f);
        subtitle.SetActive(false);
    }
}
