using UnityEngine;
using System.Collections;

public class BlinkingAura : MonoBehaviour {

	float maxDist = 1.0f;
	float speed = 1.0f;
	private Light myLight;

	void Awake()
	{
		myLight = GetComponent<Light> ();
	}
	// Update is called once per frame
	void Update () {

		myLight.range = 1.0f + Mathf.PingPong (Time.time * speed, maxDist);
	
	}
}
