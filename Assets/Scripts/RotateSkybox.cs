using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox.SetFloat("_Rotation", -270);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
