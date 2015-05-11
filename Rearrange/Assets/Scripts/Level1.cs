using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class Level1 : MonoBehaviour {

	string[] solutions = {"cake", "key", "hole"};
	public GameObject cake;
	public GameObject key;
	public GameObject hole;
	public Text tInput; //need to check after user presses enter
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
			//                //place it in the scene      //this means no rotation
				Instantiate (cake, new Vector3 (6.14F, 0.3F, 0), Quaternion.identity);
				previous = input;
				solution = true;
				break;
			case 1:
				if (door.displayed) {
					Instantiate (key, new Vector3(-3.22F, 0.33F, 0), Quaternion.identity);
					previous = input;
					solution = true;
                    StartCoroutine(ChangeLevel());
				}
				break;
			case 2:
				Instantiate (hole, new Vector3(-3.45F, 0.34F, 0), Quaternion.identity);
				previous = input;
				solution = true;
                StartCoroutine(ChangeLevel());
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
