using UnityEngine;
using System.Collections;


public class StraightWayMeteor : MonoBehaviour {

    public GameObject end;
    public GameObject sun;
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;
    public float meteorVelocity;
    private float angle;
    private float closeDistance;
    private float meteorMass = 2f;
    private Vector3 vEnd;
    private Vector3 vGravity;
    private Vector3 vResulted;
    private float fEnd;
    private float fGravity;
    private float fResulted;
    
    void MeteorResultedForces(float planetGravity, GameObject planet)
    {
        fEnd = meteorVelocity * meteorMass;        
        vEnd = end.transform.position - transform.position;
        vGravity = planet.transform.position - transform.position;
        angle = Vector3.Angle(vGravity, vEnd);
        fResulted = Mathf.Sqrt(Mathf.Pow(fEnd, 2) + Mathf.Pow(fGravity, 2) + (2 * fEnd * fGravity * Mathf.Cos(angle)));
        vResulted.Set(vEnd.x + vGravity.x, vEnd.y + vGravity.y, vEnd.z + vGravity.z);
        print("fEnd: " + fEnd + " fResulted: " + fResulted + " Gravity: " + fGravity);
        end.transform.position = end.transform.position - end.transform.position.normalized;
        transform.position = Vector3.MoveTowards(transform.position, vResulted, Time.deltaTime * fResulted);
    }

    void Awake()
    {
        meteorVelocity = 50.0f;
        
    }

    private void PlanetProximity()
    {
        
        if (SunProximity())
        {
            fGravity = 100f;
            MeteorResultedForces(fGravity, sun);            
        }

        if (MercuryProximity())
        {
            fGravity = 1f;
            MeteorResultedForces(fGravity, mercury);
        }

        if (VenusProximity())
        {
            fGravity = 1.5f;
            MeteorResultedForces(fGravity, venus);
        }

        if (EarthProximity())
        {
            fGravity = 2f;
            MeteorResultedForces(fGravity, earth);
        }

        if (MarsProximity())
        {
            fGravity = 2.5f;
            MeteorResultedForces(fGravity, earth);
        }

        if (JupiterProximity())
        {
            fGravity = 20f;
            MeteorResultedForces(fGravity, earth);
        }

        if (SaturnProximity())
        {
            fGravity = 7f;
            MeteorResultedForces(fGravity, earth);
        }

        if (UranusProximity())
        {
            fGravity = 2.2f;
            MeteorResultedForces(fGravity, earth);
        }

        if (NeptuneProximity())
        {
            fGravity = 1.2f;
            MeteorResultedForces(fGravity, earth);
        }

    }

    private bool SunProximity()
    {
        closeDistance = 1500f;
        Vector3 offset = sun.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + sun.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;            
        }

        return false;
    }

    private bool MercuryProximity()
    {
        closeDistance = 50f;
        Vector3 offset = mercury.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + mercury.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool VenusProximity()
    {
        closeDistance = 60f;
        Vector3 offset = venus.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + venus.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool EarthProximity()
    {
        closeDistance = 150f;
        Vector3 offset = earth.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + earth.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool MarsProximity()
    {
        closeDistance = 150f;
        Vector3 offset = mars.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + mars.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool JupiterProximity()
    {
        closeDistance = 600f;
        Vector3 offset = jupiter.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + jupiter.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool SaturnProximity()
    {
        closeDistance = 500f;
        Vector3 offset = saturn.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + saturn.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;

    }

    private bool UranusProximity()
    {
        closeDistance = 250f;
        Vector3 offset = uranus.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + uranus.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
            return true;
        }

        return false;
    }

    private bool NeptuneProximity()
    {
        closeDistance = 200f;
        Vector3 offset = neptune.transform.position - transform.position;
        float sqrLen = offset.sqrMagnitude;
        if (sqrLen < closeDistance)
        {
            print(sqrLen.ToString() + " km. " + "The other transform " + neptune.ToString() + "is close to me and can attract me! Min. Distance: " + closeDistance);
            if (offset.x > 0)
                end.transform.position = end.transform.position - end.transform.position.normalized;
            else
                end.transform.position = end.transform.position + end.transform.position.normalized;
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

        transform.position = Vector3.MoveTowards(transform.position, end.transform.position, Time.deltaTime * meteorVelocity);

    }
}
