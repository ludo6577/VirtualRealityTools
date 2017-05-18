using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColliderScript : MonoBehaviour {

    [HideInInspector]
    public Rigidbody CameraRigRigidbody;

    void OnTriggerEnter(Collider collider)
    {
        CameraRigRigidbody.isKinematic = false;
        Debug.Log("Fall down !");
    }
}
