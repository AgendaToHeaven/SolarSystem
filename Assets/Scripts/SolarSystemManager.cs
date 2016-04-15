using UnityEngine;
using System.Collections;

public class SolarSystemManager : MonoBehaviour {

    private GameObject selector;
    public GameObject sun;
    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;


    void Awake()
    {
        selector = Instantiate(Resources.Load("Meteorito01", typeof(GameObject))) as GameObject;
        selector.gameObject.SetActive(true);
        selector.GetComponent<StraightWayMeteor>().sun = sun;
        selector.GetComponent<StraightWayMeteor>().mercury = mercury;
        selector.GetComponent<StraightWayMeteor>().venus = venus;
        selector.GetComponent<StraightWayMeteor>().earth = earth;
        selector.GetComponent<StraightWayMeteor>().mars = mars;
        selector.GetComponent<StraightWayMeteor>().jupiter = jupiter;
        selector.GetComponent<StraightWayMeteor>().saturn = saturn;
        selector.GetComponent<StraightWayMeteor>().uranus = uranus;
        selector.GetComponent<StraightWayMeteor>().neptune = neptune;

    }

	// Use this for initialization
	void Start () {        

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
