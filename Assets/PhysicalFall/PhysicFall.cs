using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SteamVR_ControllerManager))]
public class PhysicFall : MonoBehaviour {

    public float SphereDetectionScale = 0.5f;
    public Transform SpherePrefab;
    public List<SteamVR_TrackedObject> TrackedObjects;

    private Rigidbody cameraRigRigidbody;

    
	// Use this for initialization
	void Start() {
        // CameraRig RigidBody (Makes fall the scene)
        cameraRigRigidbody = transform.gameObject.AddComponent<Rigidbody>();
        cameraRigRigidbody.isKinematic = true;

        foreach (var trackedObject in TrackedObjects)
        {
            var gameObject = Instantiate(SpherePrefab, trackedObject.transform.position, Quaternion.identity);
            gameObject.SetParent(trackedObject.transform);
            var collider = gameObject.GetComponent<SphereColliderScript>();
            collider.CameraRigRigidbody = cameraRigRigidbody;
        }
	}

    void Update()
    {
    }
}








//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class AlphaFade : MonoBehaviour
//{
//    public float fade;
//    public float fadeSpeed = 1f;
//    public float fadeTime = 1f;
//    public bool fadeIn = true;
//    public SpriteRenderer text;

//    // Update is called once per frame
//    void Update()
//    {


//        if (fadeIn)
//        {
//            float Fade = Mathf.SmoothDamp(0f, 1f, fadeSpeed, fadeTime);
//            text.color = new Color(1f, 1f, 1f, Fade);
//        }

//        if (!fadeIn)
//        {
//            float Fade = Mathf.SmoothDamp(1f, 0f, fadeSpeed, fadeTime);
//            text.color = new Color(1f, 1f, 1f, Fade);
//        }
//    }
//}