using UnityEngine;
using System.Collections;

public class StraightWayMeteor : MonoBehaviour {

    public Vector3 end;
    public float velocity;
    private float distance;
    private Vector3 desiredPosition;

    void Awake()
    {
        velocity = 0.0f;   
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, end, Time.deltaTime * velocity);
    }
}
