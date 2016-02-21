using UnityEngine;
using System.Collections;

public class CubeLightIntensity : MonoBehaviour {




	// Use this for initialization
	void Start () {
		
		Light light = GetComponent<Light>();
		light.intensity = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		Light light = GetComponent<Light>();

		if (light.intensity > 7) {
			light.intensity = 0;
		}

		light.intensity = Mathf.Lerp (light.intensity, 8f, 0.5f * Time.deltaTime);

	
	}
}
