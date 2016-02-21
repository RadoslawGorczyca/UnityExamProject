using UnityEngine;
using System.Collections;

public class Totem : MonoBehaviour {
    public GameObject obj1, obj2;
    public Light swiatlo;

    public float distance;
    public bool prawda = false;

    public GameObject parent;
    // Use this for initialization
    void Start () {
        distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
	    swiatlo = gameObject.GetComponent<Light>();
        
    }

    // Update is called once per frame
    
     void Update()
    {
        if (!prawda)
        {
            distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
            swiatlo.range = 1 / (distance / 10);
        }
        else
        {
            swiatlo.range = 0;
        }
    }
}
