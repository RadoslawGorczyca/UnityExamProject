using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pupup : MonoBehaviour {
    Text Target;

	// Use this for initialization
	void Start () {
        Target = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
        Target.text = "";
	
	}
}
