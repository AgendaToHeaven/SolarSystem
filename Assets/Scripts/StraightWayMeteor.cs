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
    private float angle;
    private float closeDistance;
    private Vector3 vEnd;
    private Vector3 vGravity;
    private Vector3 vResulted;
    private float fEnd;
    private float fGravity;
    private float fResulted;
    


    void Awake()
    {
        velocity = 50.0f;
        closeDistance = 2000f;
    }

    private void PlanetProximity()
    {
        if (SunProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = sun.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (MercuryProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = mercury.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (VenusProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = venus.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (EarthProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = earth.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (MarsProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = mars.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (JupiterProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = jupiter.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (SaturnProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = saturn.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (UranusProximity())
        {
            fEnd = velocity;
            fGravity = 1;
            vEnd = end.position - transform.position;
            vGravity = uranus.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }

        if (NeptuneProximity())
        {
            fEnd = velocity;
            fGravity = 10;
            vEnd = end.position - transform.position;
            vGravity = neptune.position - transform.position;
            angle = Vector3.Angle(vEnd, vGravity);
            fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
            vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);

            transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
        }
        
    }

    private bool SunProximity()
    {
        Vector3 offset = sun.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance * closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + sun.ToString() +"is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + mercury.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + venus.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + earth.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + mars.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + jupiter.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + saturn.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + uranus.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
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
            print(sqrLen.ToString() + " km. " + "The other transform " + neptune.ToString() + "is close to me and can attract me! Distance: " + sqrLen);
            return true;
        }

        return false;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        PlanetProximity();

        transform.position = Vector3.MoveTowards(transform.position, end.position, Time.deltaTime * velocity);

    }
}
