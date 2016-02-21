using UnityEngine;
using System.Collections;

public class PortalCol2 : MonoBehaviour {
    public LevelManager lvl;

    public void OnTriggerEnter(Collider col)
    {
        lvl.LoadScene("Level2");
    }
}
