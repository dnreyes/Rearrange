using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

    void OnMouseDown()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}