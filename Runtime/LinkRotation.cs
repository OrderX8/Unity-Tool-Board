using UnityEngine;

namespace UnityToolBoard
{
    public class LinkRotation : MonoBehaviour
    {
        public Transform targetObject;

        public bool xRotation = true;
        public bool yRotation = true;
        public bool zRotation = true;

        void Update()
        {
            Vector3 currentRotation = transform.localEulerAngles;
            
            if (xRotation) { currentRotation.x = targetObject.localEulerAngles.x; }
            if (yRotation) { currentRotation.y = targetObject.localEulerAngles.y; }
            if (zRotation) { currentRotation.z = targetObject.localEulerAngles.z; }
            transform.localEulerAngles = currentRotation;
        }
    }
}