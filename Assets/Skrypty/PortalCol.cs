using UnityEngine;
using System.Collections;

public class PortalCol : MonoBehaviour {
    public LevelManager lvl;

    public void OnTriggerEnter(Collider col)
    {
            lvl.LoadScene("Level1");
    }
}
