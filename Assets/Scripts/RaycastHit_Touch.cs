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
            Debug.Log("Inside if Touch");
            if(arRayMan.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                Debug.Log("ARRayMan.Raycast");
                var hitpose = hits[0].pose;
                if (!object_spawned)
                {
                    Debug.Log("Inside if if object spawned false");
                    spwaned_object = Instantiate(spwan_Prefab, hitpose.position, hitpose.rotation);
                    object_spawned = true;
                }
                else
                {
                    Debug.Log("Inside else");
                    spwaned_object.transform.position = hitpose.position;
                }
            }
        }
    }
}
