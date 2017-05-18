using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class FadeScript : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            //cameraRigRigidbody.position = Camera.transform.position;
            if (Input.GetKey(KeyCode.A))
                Fade();
        }

        public GameObject FadePlane;
        [Range(0.01f, 0.5f)]
        public float FadeSpeed;

        private bool fadeOut;

        void Fade()
        {
            StartCoroutine(Fade(FadePlane.GetComponent<Renderer>().material));
        }

        public IEnumerator Fade(Material material)
        {
            fadeOut = true;

            while (fadeOut && material.color.a >= 0f)
            {
                material.color = new Color(material.color.r, material.color.g, material.color.b, material.color.a - FadeSpeed);
                yield return new WaitForEndOfFrame();
            }

            while (material.color.a <= 1f)
            {
                material.color = new Color(material.color.r, material.color.g, material.color.b, material.color.a + FadeSpeed);
                yield return new WaitForEndOfFrame();
            }

            fadeOut = false;
        }
    }
}
