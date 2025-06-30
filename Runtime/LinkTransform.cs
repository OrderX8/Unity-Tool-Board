using UnityEngine;

namespace UnityToolBoard
{
    public class LinkTransform : MonoBehaviour
    {
        public Transform targetObject;
        void Update()
        {
            transform.position = targetObject.position;
            transform.rotation = targetObject.rotation;
            transform.localScale = targetObject.localScale;
        }
    }
}