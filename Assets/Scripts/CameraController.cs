using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    private float lookSpeed;
    private float moveSpeed;

    private float rotationX;
    private float rotationY;

    // Use this for initialization
    void Start()
    {
        lookSpeed = 10.0f;
        moveSpeed = 5.0f;
        rotationX = 0.0f;
        rotationY = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY += Input.GetAxis("Mouse Y") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -90, 90);

        transform.localRotation = Quaternion.AngleAxis(rotationX, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(rotationY, Vector3.left);

        transform.position += transform.forward * moveSpeed * Input.GetAxis("Vertical");
        transform.position += transform.right * moveSpeed * Input.GetAxis("Horizontal");

    }
}
