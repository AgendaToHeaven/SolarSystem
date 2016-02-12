using UnityEngine;
using System.Collections;

public class SunRotationController : MonoBehaviour
{

    public float radiusSpeed = 44.99f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, radiusSpeed * Time.deltaTime, Space.Self);

    }
}
