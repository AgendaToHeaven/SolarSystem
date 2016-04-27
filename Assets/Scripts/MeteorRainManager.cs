using UnityEngine;
using System.Collections;

public class MeteorRainManager : MonoBehaviour {

    private float radiusSpeed;
    private float velocity;
    public GameObject end;
    private GameObject origin;


    void Awake()
    {
        origin = new GameObject();
        origin.transform.position = transform.position;
    }

    void Start()
    {
        Random.seed = 15;
        radiusSpeed = Random.value / Time.realtimeSinceStartup;
        velocity = Random.value / Time.realtimeSinceStartup;
        print("RadSpeed = " + radiusSpeed + "Velocity = " + velocity);

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(Vector3.up, radiusSpeed * Time.deltaTime, Space.Self);
        transform.position = Vector3.MoveTowards(transform.position, end.transform.position, Time.deltaTime);
        if (Mathf.Approximately(transform.position.x, end.transform.position.x) &&
            Mathf.Approximately(transform.position.y, end.transform.position.y) &&
            Mathf.Approximately(transform.position.z, end.transform.position.z))
        {
            transform.position = origin.transform.position;
        }
    }
}
