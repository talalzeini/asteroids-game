using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float RotateSpeed = 5f;
    

    // Update is called once per frame
    void Update()
    {
    RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
    }
}
