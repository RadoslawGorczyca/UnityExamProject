using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interact : MonoBehaviour {
    GUITexture Image;
    public Text Target;
    private bool selected = false;
    public GlobalObject global;
    public LevelManager lvl;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        selected = false;
        Target.GetComponent<pupup>().BrakNapis();
	}

    public void OnLookEnter()
    {
        Target.GetComponent<pupup>().Napis();
        selected = true;

        if (Input.GetKeyDown(KeyCode.E) && selected)
        {
            global = GameObject.FindObjectOfType<GlobalObject>();
            global.LocalCopyOfData.Art1 = true;
            global.IsBeingLoaded = true;
            global.savedPlayerData.PositionX = 169.39f;
            global.savedPlayerData.PositionY = 19.36f;
            global.savedPlayerData.PositionZ = 124.48f;
            lvl = GameObject.FindObjectOfType<LevelManager>();
            lvl.LoadScene("Las");
            Destroy(gameObject);
        }
    }

    public void OnGUI()
    {
        /*
        if (Input.GetKeyDown(KeyCode.E) && selected)
        {
            global = GameObject.FindObjectOfType<GlobalObject>();
            global.LocalCopyOfData.Art1 = true;
            global.IsBeingLoaded = true;
            global.savedPlayerData.PositionX = 169.39f;
            global.savedPlayerData.PositionY = 19.36f;
            global.savedPlayerData.PositionZ = 124.48f;
            lvl = GameObject.FindObjectOfType<LevelManager>();
            lvl.LoadScene("Las");
            Destroy(gameObject);
        }
        */
    }
}
