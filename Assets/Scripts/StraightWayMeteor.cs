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

    private void SunProximity()
    {
        Vector3 offset = sun.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() +"is close to me and can attract me!");
            if (sun.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void MercuryProximity()
    {
        Vector3 offset = mercury.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + mercury.ToString() + " is close to me and can attract me!");
            if (mercury.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void VenusProximity()
    {
        Vector3 offset = venus.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + venus.ToString() + " is close to me and can attract me!");
            if (venus.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void EarthProximity()
    {
        Vector3 offset = earth.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + earth.ToString() + " is close to me and can attract me!");
            if (earth.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void MarsProximity()
    {
        Vector3 offset = mars.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + mars.ToString() + " is close to me and can attract me!");
            if (mars.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void JupiterProximity()
    {
        Vector3 offset = jupiter.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + jupiter.ToString() + " is close to me and can attract me!");
            if (jupiter.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void SaturnProximity()
    {
        Vector3 offset = saturn.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + saturn.ToString() + " is close to me and can attract me!");
            if (saturn.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void UranusProximity()
    {
        Vector3 offset = uranus.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + uranus.ToString() + " is close to me and can attract me!");
            if (uranus.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
    }

    private void NeptuneProximity()
    {
        Vector3 offset = neptune.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + neptune.ToString() + " is close to me and can attract me!");
            if (neptune.position.x > transform.position.x)
            {
                print("Trayectoria modificada derecha");
                end.Translate(Vector3.right.normalized);
            }
            else
            {
                print("Trayectoria modificada izquiera");
                end.Translate(Vector3.left.normalized);
            }
        }
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

        SunProximity();
        MercuryProximity();
        VenusProximity();
        EarthProximity();
        MarsProximity();
        JupiterProximity();
        SaturnProximity();
        UranusProximity();
        NeptuneProximity();

        transform.position = Vector3.MoveTowards(transform.position, end.position, Time.deltaTime * velocity);
    }
}
