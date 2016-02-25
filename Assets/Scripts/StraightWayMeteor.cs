using UnityEngine;

public class StraightWayMeteor : MonoBehaviour {

    public Transform end;
    public Transform sun;
    public Transform mercury;
    public Transform venus;
    public Transform earth;
    public Transform mars;
    public Transform jupiter;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;
    public float velocity;
    private float closeDistance;


    void Awake()
    {
        velocity = 50.0f;
        closeDistance = 1000f;
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*targetDir = end.position - transform.position;
        angle = Angle(targetDir);
        if(angle > 100f)
        {
            transform.RotateAround(end.position, targetDir, velocity * Time.deltaTime);
        }*/
        // Gets a vector that points from the meteor's position to the target's and calculate distance.

        Vector3 offset = sun.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform is close to me and can attract me!");
            if (end.position.x > transform.position.x)
            {
                print("Trayectoria modificada izquierda");
                end.Translate(Vector3.left.normalized);
            }
            else
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, end.position, Time.deltaTime * velocity);
    }
}
