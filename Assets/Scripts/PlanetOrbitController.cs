using UnityEngine;


public class PlanetOrbitController : MonoBehaviour
    {

        public Transform center;
        private float radius;
        public float radiusSpeed;
        public float rotationSpeed;
        public Vector3 axis;
        public Vector3 desiredPosition;


        void Awake()
        {
            axis = Vector3.up;
            radius = Mathf.Abs(transform.localPosition.z - center.localPosition.z);
        }

        void Start()
        {
            transform.position = (transform.position - center.position).normalized * radius + center.position;
        }

        // Update is called once per frame
        void Update()
        {

            transform.Rotate(Vector3.up, radiusSpeed * Time.deltaTime, Space.Self);
            transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime);
            desiredPosition = (transform.position - center.position).normalized * radius + center.position;
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
        }
   }

