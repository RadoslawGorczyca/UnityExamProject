using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour {

	public GameObject otherObject;
	private Destroy destroy;
	int x = 0; 


	void Awake()
	{
		destroy = GetComponent<Destroy> ();
	}
	void OnMouseDown()
	{
		Rigidbody rg = GetComponent<Rigidbody>();
		Debug.Log ("Kliku, kliku, klik!");
		rg.AddForce (-transform.forward * 500);
		if (x == 0) 
		{
			destroy.Start ();
			x = 1; 
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (x != 0) 
		{
			destroy.Update ();
		}
	
	}
}
