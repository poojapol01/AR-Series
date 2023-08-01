using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;

public class Light_Estimate : MonoBehaviour
{
    public ARCameraManager arCamMan;
    Light ourLight;
    public TMP_Text brightness;

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
        if (args.lightEstimation.mainLightColor.HasValue)
        {
            //brightness.text = $"Color Value: {args.lightEstimation.mainLightColor.Value}";
            ourLight.color = args.lightEstimation.mainLightColor.Value;
            float average_btightness = 0.2126f * ourLight.color.r + 0.7152f * ourLight.color.g + 0.0722f * ourLight.color.b;
            brightness.text = average_btightness.ToString();
        } 
    }
}
