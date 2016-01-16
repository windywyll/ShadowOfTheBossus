using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuInGame : MonoBehaviour {

    public Button button;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Crouch"))
        {
            button.Select();
            button.onClick.Invoke();
        }
	}
}
