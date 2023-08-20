using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTrackingAR : MonoBehaviour
{
    private ARTrackedImageManager atImageManager;

    private void Awake()
    {
        atImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        atImageManager.trackedImagesChanged += OnImageChanged;
    }
    private void OnDisable()
    {
        atImageManager.trackedImagesChanged -= OnImageChanged;
    }
    private void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
