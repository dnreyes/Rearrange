using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float score = 0f;
    private float fillRate = 0.2f;
    Image image;
    void Start()
    {
         image = GetComponent<Image>();

        image.fillAmount = 0f;
    }

	void Update () {
        image.fillAmount = Mathf.MoveTowards(image.fillAmount, score, fillRate*Time.deltaTime);
	}

    public int IncreaseScore(float currScore, bool isAnim, bool isSolution)
    {
        return 0;
    }
}
