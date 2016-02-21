using UnityEngine;
using System.Collections;

public class ArtifactFloat : MonoBehaviour {

	//bool floatUp;
	float moveSpeed = 5f;
	float amplitude = 0.01f; 
	float y;

	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Vector3.up * amplitude * Mathf.Sin (moveSpeed * Time.time));

	}
}