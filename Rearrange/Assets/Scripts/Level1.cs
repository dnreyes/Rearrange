using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class Level1 : MonoBehaviour {

	private string[] solutions = {"cake", "key", "hole", "cheese", "code", "dart", "delete", "oil", "kite"};
	private string prompt = "There is a locked door";

	public GameObject cake;
	public GameObject key;
	public GameObject hole;
	public GameObject cheese;
	public GameObject code;
	public GameObject dart;
	public GameObject delete;
	public GameObject oil;
	public GameObject kite;

	public Text tInput; //need to check after user presses enter

	private GameObject onScreen = null;
	private bool solution = false; //prevents creating infinte objects on update
	private string previous;

	public SampleDoor door;

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
		//                                 //place it in the scene      //this means no rotation
		gObject = GameObject.Instantiate (gObject, new Vector3 (x, y, 0), Quaternion.identity) as GameObject;
		onScreen = gObject;
		solution = true;
	}

	//********* PROMPT *********//

	//calculates the prompt size to fit onto the camera/canvas
	int calPromptSize() {
		int length = 0;
		
		for (int i = 0; i < prompt.Length; i++) {
			if (prompt [i] != ' ') {
				length += 5;//approx size of tile
			} else {
				length += 2;//approx size of space inbetween words
			}
		}
		return length;
	}

	//place prompt in scene
	void displayPrompt(int promptsize) {
		int place = promptsize;
		int border = 20;
		int initalPos = 20;
		int width = Camera.pixelWidth - border;
		bool extra = false; //check for need of new line

		//if the prompt can fit in one line
		if (width >= place) {
			initalPos = (width - place) / 2;
		} else {
			extra = true;
		}

		//if the prompt is longer that width than create a new line
		for (int i = 0; i < prompt.Length; i++) {
			//go through prompt and place them in the scene
		}
	}

	//mostly used for debugging
	void Start() {
		print (calPromptSize ());
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
				break;
			case 1:
				if (door.displayed) {
					previous = input;
					solution = true;
					displayAnim(key, -3.22F, 0.33F);
                    StartCoroutine(ChangeLevel());
				}
				break;
			case 2:
				previous = input;
				solution = true;
				displayAnim(hole, -3.45F, 0.34F);
                StartCoroutine(ChangeLevel());
				break;
			case 3:
				previous = input;
				displayAnim(cheese, 0.62F, 0.99F);
				break;
			case 4:
				previous = input;
				displayAnim(code, -3.29F, 1.07F);
                StartCoroutine(ChangeLevel());
				break;
			case 5:
				previous = input;
				displayAnim(dart, 0.59F, 0.36F);
				break;
			case 6:
				previous = input;
				displayAnim(delete, -2.44F, -2.37F);
                StartCoroutine(ChangeLevel());

				break;
			case 7:
				previous = input;
				displayAnim(oil, -4.08F, 2.2F);
				break;
			case 8:
				previous = input;
				displayAnim(kite, -2.31F, 0.36F);
				break;
			default:
				break;
			}
		}
	}

    IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(3.5f);
        float fadeTime = GameObject.Find("_LevelManager").GetComponent<Fade>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        Application.LoadLevel(Application.loadedLevel + 1);
    }	
}
