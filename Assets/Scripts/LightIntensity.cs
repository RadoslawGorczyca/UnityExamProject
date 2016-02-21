using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour {

	private Light myLight;

	// Use this for initialization
	void Start () {

		myLight = GetComponent<Light> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.P)) {
			myLight.range += 0.5f;
		}
		if (Input.GetKeyUp (KeyCode.M)) {
			myLight.range -= 0.5f;
		}
	}
}
