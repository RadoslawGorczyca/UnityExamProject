using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pupup : MonoBehaviour {
    Text Target;
    public string txt;

	// Use this for initialization
	void Start () {
        Target = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update () {
        Target.text = txt;
	
	}

    public void Napis()
    {
        txt = "Naciśńij E";
    }

    public void BrakNapis()
    {
        txt = "";
    }
}
