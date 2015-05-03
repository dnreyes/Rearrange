using UnityEngine;
using System.Collections;

public class KeyboardScript : MonoBehaviour {

    bool toggleKeyboard = false;
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 1)
        {
            toggleKeyboard = !toggleKeyboard;
        }
        if (toggleKeyboard)
        {
            string message = "";
            message += "I am being toggled \n";

            GUI.Label(new Rect(200, 200, 120, 100), message);
        }
	}
}
