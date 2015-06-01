using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour
{

    public void ReplayLevel()
    {
        Debug.Log("I am clicking replay");
        Application.LoadLevel(Application.loadedLevel);
    }
}