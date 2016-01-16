using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mainMenuPad : MonoBehaviour {

    public Button[] buttonTab = new Button[3];
    private int index = 0;
    private float delayChangeButton = 0.1f;
    private float startDelay;

    // Use this for initialization
    void Start () {
        buttonTab[index].Select();
        startDelay = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(index);

	    if(Input.GetAxis("Vertical") > 0 && (startDelay + delayChangeButton) > Time.time)
        {
            startDelay = Time.time;
            if (index > 0)
                index--;

            buttonTab[index].Select();
        }

        if(Input.GetAxis("Vertical") < 0 && (startDelay + delayChangeButton) > Time.time)
        {
            startDelay = Time.time;
            if (index < 2)
                index++;

            buttonTab[index].Select();
        }
	}
}
