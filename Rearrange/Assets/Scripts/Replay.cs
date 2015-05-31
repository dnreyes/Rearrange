using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

    private bool replay = false;

    void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel);
        replay = true;
    }

    public bool isReplay()
    {
        return replay;
    }
}