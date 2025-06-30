using UnityEngine;

namespace UnityToolBoard
{
    public class LinkScale : MonoBehaviour
    {
        public Transform targetObject;

        public bool xScale = true;
        public bool yScale = true;
        public bool zScale = true;

        void Update()
        {
            Vector3 currentScale = transform.localScale;
            if (xScale) { currentScale.x = targetObject.localScale.x; }
            if (yScale) { currentScale.y = targetObject.localScale.y; }
            if (zScale) { currentScale.z = targetObject.localScale.z; }
            transform.localScale = currentScale;
        }
    }
}