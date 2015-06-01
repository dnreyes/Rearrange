using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class Level1 : MonoBehaviour {

	private string[] solutions = {"cake", "key", "hole", "cheese", "code", "dart", "delete", "oil", "kite"};
	private string prompt = "There is a locked door";

	//public Camera gameCamera;

	public GameObject cake;
	public GameObject key;
	public GameObject hole;
	public GameObject cheese;
	public GameObject code;
	public GameObject dart;
	public GameObject delete;
	public GameObject oil;
	public GameObject kite;

    public GameObject ReplayButton;
    public GameObject NextButton;

	public Text tInput; //need to check after user presses enter

	private GameObject onScreen = null;
	private bool solution = false; //prevents creating infinte objects on update
    private bool levelComplete = false;
    private static float score;
	private string previous;

	public SampleDoor door;
	private Tiles gameTiles;
	public Score scoreBar;

    void Start()
    {
        if (!levelComplete)
        {
            score = 0f;
            Debug.Log("The buttons should be hiding right now");
            ReplayButton.gameObject.SetActive(false);
            NextButton.gameObject.SetActive(false);
        }
    }

	int checkInput (string input) {
		int index = -1;
		//print (input + " " + solutions [0]);
		for (int i = 0; i < solutions.Length; i++) {
			if (solutions[i].Equals (input)) {
				index = i;
			}
		}
		return index;
	}


	//********* ANIMATIONS *********//

	//Display words with animations
	void displayAnim (GameObject gObject, float x, float y) {
		if (onScreen != null) {
			Destroy (onScreen);
		}
		//place it in the scene      //this means no rotation
		gObject = GameObject.Instantiate (gObject, new Vector3 (x, y, 0), Quaternion.identity) as GameObject;
		onScreen = gObject;
		solution = true;
	}

	void Update() {

		string input = tInput.text;
		int index = checkInput (input);

		//checks for new input
		if (!input.Equals (previous)) {
			solution = false;
		}

		if (!solution) {
			switch (index) {
			case 0:
				previous = input;
				displayAnim(cake, 6.14F, 0.3F);
                score += scoreBar.IncreaseScore(score, input, true, false);
                scoreBar.score = score;
				break;
                
			case 1:
				if (door.displayed) {
					previous = input;
					solution = true;
					displayAnim(key, -3.22F, 0.33F);
                    score = scoreBar.IncreaseScore(score, input, true, true);
                    scoreBar.score = score;
                    levelComplete = true;
				}
				break;
			case 2:
				previous = input;
				solution = true;
				displayAnim(hole, -3.45F, 0.34F);
                score = scoreBar.IncreaseScore(score, input, true, true);
                scoreBar.score = score;
                levelComplete = true;
				break;
			case 3:
				previous = input;
				displayAnim(cheese, 0.62F, 0.99F);
                score += scoreBar.IncreaseScore(score, input, true, false);
                scoreBar.score = score;
				break;
			case 4:
				previous = input;
                solution = true; 
				displayAnim(code, -3.29F, 1.07F);
                score = scoreBar.IncreaseScore(score, input, true, true);
                scoreBar.score = score;
                levelComplete = true;
				break;
			case 5:
				previous = input;
				displayAnim(dart, 0.59F, 0.36F);
                score += scoreBar.IncreaseScore(score, input, true, false);
                scoreBar.score = score;
				break;
			case 6:
				previous = input;
				displayAnim(delete, -2.44F, -2.37F);
                score = scoreBar.IncreaseScore(score, input, true, true);
                scoreBar.score = score;
                levelComplete = true;
				break;
			case 7:
				previous = input;
				displayAnim(oil, -4.08F, 2.2F);
                score += scoreBar.IncreaseScore(score, input, true, false);
                scoreBar.score = score;
				break;
			case 8:
				previous = input;
				displayAnim(kite, -2.31F, 0.36F);
                score += scoreBar.IncreaseScore(score, input, true, false);
                scoreBar.score = score;
				break;
			default:
				break;
			}
		}

        //Checking to see if a solution is found.
        if (levelComplete)
        {
            //Show the next level and replay buttons after a few seconds
            StartCoroutine(ShowButton());
	}
	}

    //IEnumerator Functions
    IEnumerator ShowButton()
    {
        yield return new WaitForSeconds(3.5f);
        ReplayButton.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
    }	

}
