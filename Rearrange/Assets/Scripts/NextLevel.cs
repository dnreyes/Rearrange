using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

    public void Click()
    {
        StartCoroutine(ChangeLevel());
    }

    IEnumerator ChangeLevel()
    {
        float fadeTime = GameObject.Find("_LevelManager").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
