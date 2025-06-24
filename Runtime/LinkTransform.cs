using UnityEngine;

namespace UnityToolBoard
{
    public class LinkTransform : MonoBehaviour
    {
        public Transform targetObject;
        void Update()
        {
            transform.position = targetObject.position;

            //transform.rotation = linkedObject.rotation;
            //transform.localScale = linkedObject.localScale;
        }
    }
}