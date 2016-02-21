using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

	public int moveSpeed = 10;
	public int turnSpeed = 50;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if ((Input.GetKey (KeyCode.R)) && (gameObject.GetComponent<Renderer>().material.color != Color.red)) 
		{

			gameObject.GetComponent<Renderer>().material.color = Color.red;
			Debug.Log ("Red");

		}
		if ((Input.GetKey (KeyCode.W)) && (gameObject.GetComponent<Renderer>().material.color != Color.white)) 
		{

			gameObject.GetComponent<Renderer>().material.color = Color.white;
			Debug.Log ("White");
		}

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate (Vector3.up * -turnSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.Q)) 
		{
			transform.Rotate (Vector3.left * -turnSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.E)) 
		{
			transform.Rotate (Vector3.left * turnSpeed * Time.deltaTime);
		}


	
	}
}
