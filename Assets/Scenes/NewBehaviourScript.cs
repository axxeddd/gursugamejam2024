using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NewBehaviourScript : MonoBehaviour
{
    private AmbientOcclusion ao;
    
    void Start()
    {
        GetComponent<PostProcessVolume>().profile.TryGetSettings(out ao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
