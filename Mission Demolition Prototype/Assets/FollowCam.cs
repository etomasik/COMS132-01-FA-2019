using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    static public GameObject POI;
    [Header("Set Dynamically")]
    public float    camZ;

    private void Awake()
    {
        camZ = this.transform.position.z;
    }

    private void FixedUpdate()
    {
        if (POI == null) return;
        Vector3 destination = POI.transform.position;
        destination.z = camZ;
        transform.position = destination;
    }
}
