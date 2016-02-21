using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WallCol : MonoBehaviour {
    public Text txt ;

    public void OnCollisionEnter(Collision col)
    {
        txt.text = "Wychodzisz z lasu, zawróć";
        Debug.Log(col.rigidbody.name);
    }
    public void OnCollisionStay(Collision col)
    {
        txt.text = "Wychodzisz z lasu, zawróć";
    }
    public void OnCollisionExit(Collision col)
    {
        txt.text = "";
    }
}
