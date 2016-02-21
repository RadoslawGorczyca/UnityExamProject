using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	
	public float sekundy;
	public float end;

	// Use this for initialization
	public void Start () {

		sekundy = Time.time + 10;
		Destroy (gameObject, 10);
	}
	
	// Update is called once per frame
	public void Update () {

		end = sekundy - Time.time;
	
	}
}
