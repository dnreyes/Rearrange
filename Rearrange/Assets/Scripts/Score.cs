using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float score = 0f;
    private float fillRate = 0.2f;
    private List<string> wordUsed = new List<string>();
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0f;
    }

	void Update () {
        image.fillAmount = Mathf.MoveTowards(image.fillAmount, score, fillRate*Time.deltaTime);
	}

    public float IncreaseScore(float currScore, string word, bool isAnim, bool isSolution)
    {
        float newScore = 0f;
        float animScore = 0.01f;
        if (wordUsed.IndexOf(word.ToString().ToLower()) == -1)
        {
            if (isSolution)
            {
                //If they have no star yet
                if (currScore == 0f || currScore < 0.27f)
                {
                    newScore = 0.3132f;
                }
                //If they have one star
                else if (currScore < 0.6f)
                {
                    newScore = 0.645f;
                }
                //they have two stars
                else newScore = 1f;
            }
            //This means that it is not a solution
            //but it is animated
            else if (isAnim && !isSolution)
            {
                float length = (float)word.Length * animScore;
                Debug.Log(length);
                newScore = length + animScore;
            }
            //It is not animated but a valid word
            else
            {
                newScore = (float)word.Length * (0.01f);
            }
            wordUsed.Add(word.ToString());
        }
        return newScore;
    }
}
