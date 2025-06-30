using UnityEngine;

namespace UnityToolBoard
{
    public class LinkPosition : MonoBehaviour
    {
        public Transform targetObject;

        public bool xPosition = true;
        public bool yPosition = true;
        public bool zPosition = true;

        void Update()
        {
            Vector3 currentPosition = transform.position;
            if (xPosition) { currentPosition.x = targetObject.position.x; }
            if (yPosition) { currentPosition.y = targetObject.position.y; }
            if (zPosition) { currentPosition.z = targetObject.position.z; }
            transform.position = currentPosition;
        }
    }
}