using UnityEngine;
using System.Collections;

public class HaloOnOff : MonoBehaviour {

	//private Halo myHalo;

	// Use this for initialization
	void Start () 
	{
		//myHalo = GetComponent<Halo> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.H)) 
		{
			//myHalo.enabled = !myHalo.enabled;
			(gameObject.GetComponent("Halo") as Behaviour).enabled = !(gameObject.GetComponent("Halo") as Behaviour).enabled; 
		}

		//if (Input.GetKeyUp (KeyCode.P)) 
		//{
			//myHalo.enabled = !myHalo.enabled;
		//	(gameObject.GetComponent("Halo") as Behaviour).intensity += 1; 
		//}
	}
}
