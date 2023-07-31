using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Light_Estimate : MonoBehaviour
{
    public ARCameraManager arCamMan;
    Light ourLight;

    private void OnEnable()
    {
        arCamMan.frameReceived += GetLight; 
    }
    private void OnDisable()
    {
        arCamMan.frameReceived -= GetLight;
    }

    private void Start()
    {
        ourLight = GetComponent<Light>();
    }

    private void GetLight(ARCameraFrameEventArgs args)
    {
        Debug.Log("Light Estimation: " +args.lightEstimation);
    }
}
