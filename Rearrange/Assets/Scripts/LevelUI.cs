using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour {
    
    public class PlayerStats
    {
        //starting score for each level
        public float score = 0f;
        //stores words from each level
        List<string> wordsFound = new List<string>();
    }

    public PlayerStats playerStats = new PlayerStats();
	public Image visualScore;
    public RectTransform scoreTransform;
    private float cachedY;
    private float minX;
    private float maxX;
    public float maxScore = 100f;

	// Use this for initialization
	void Start () {

        cachedY = scoreTransform.position.y;
        maxX = scoreTransform.position.x;
        minX = maxX - scoreTransform.rect.width;
        //making sure that score always starts at 0
        playerStats.score = 0f;
	}
	
	// Update is called once per frame
	void Update () {

	}


}