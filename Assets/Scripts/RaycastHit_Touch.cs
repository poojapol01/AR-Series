using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RaycastHit_Touch : MonoBehaviour
{
    public GameObject spwan_Prefab;

    GameObject spwaned_object;

    bool object_spawned;

    ARRaycastManager arRayMan;

    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Start()
    {
        object_spawned = false;
        arRayMan = GetComponent<ARRaycastManager>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            if(arRayMan.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                var hitpose = hits[0].pose;
                if (!object_spawned)
                {
                    spwaned_object = Instantiate(spwan_Prefab, hitpose.position, hitpose.rotation);
                    object_spawned = true;
                }
                else
                {
                    spwaned_object.transform.position = hitpose.position;
                }
            }
        }
    }
}
