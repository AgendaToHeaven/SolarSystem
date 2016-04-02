using UnityEngine;
using System.Collections;


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
    public float angle;
    private float closeDistance;
    private Vector3 vEnd;
    private Vector3 vGravity;
    private float fEnd;
    private float fGravity;
    private float fResulted;
    


    void Awake()
    {
        velocity = 50.0f;
        closeDistance = 500f;
    }

    private void PlanetProximity()
    {
        if (SunProximity())
        {
            fEnd = velocity;
            fGravity = 100;
            vEnd = end.position - transform.position;
            vGravity = sun.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));



        }

    }

    private bool SunProximity()
    {
        Vector3 offset = sun.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() +"is close to me and can attract me!");
            return true;            
        }

        return false;
    }

    private bool MercuryProximity()
    {
        Vector3 offset = mercury.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool VenusProximity()
    {
        Vector3 offset = venus.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool EarthProximity()
    {
        Vector3 offset = earth.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool MarsProximity()
    {
        Vector3 offset = mars.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool JupiterProximity()
    {
        Vector3 offset = jupiter.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool SaturnProximity()
    {
        Vector3 offset = saturn.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;

    }

    private bool UranusProximity()
    {
        Vector3 offset = uranus.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;
    }

    private bool NeptuneProximity()
    {
        Vector3 offset = neptune.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " 10^6 km. " + "The other transform " + sun.ToString() + "is close to me and can attract me!");
            return true;
        }

        return false;
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

        PlanetProximity();

        transform.position = Vector3.MoveTowards(transform.position,end.position.normalized, Time.deltaTime * velocity);

    }
}
