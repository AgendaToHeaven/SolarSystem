using UnityEngine;
using System.Collections;

public class MirandaUranusMoonOrbitController : MonoBehaviour
{

    public GameObject mars;
    public Transform center;
    public Vector3 axis = Vector3.up;
    public Vector3 desiredPosition;
    public float radius = 0.0f;
    public float radiusSpeed = 0.46f;
    public float rotationSpeed = 8f;


    // Use this for initialization
    void Start()
    {
        //earth = GameObject.Find("Earth");
        radius = Mathf.Abs(transform.position.magnitude - center.position.magnitude);
        transform.position = (transform.position - center.position).normalized * radius + center.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, radiusSpeed * Time.deltaTime, Space.Self); //Rotation around own Y axis
        transform.RotateAround(center.position, axis, rotationSpeed * Time.deltaTime); //Rotation around Mars
        desiredPosition = (transform.position - center.position).normalized * radius + center.position; //Future position
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);

    }
}
