using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float score = 0f;
    Image image;
    void Start()
    {
         image = GetComponent<Image>();

        image.fillAmount = 0f;
    }

	void Update () {
        image.fillAmount = score;
	}
}
