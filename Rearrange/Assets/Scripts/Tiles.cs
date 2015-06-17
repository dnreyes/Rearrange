using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tiles : MonoBehaviour {

	public GameObject tileA;
	public GameObject tileB;
	public GameObject tileC;
	public GameObject tileD;
	public GameObject tileE;
	public GameObject tileF;
	public GameObject tileG;
	public GameObject tileH;
	public GameObject tileI;
	public GameObject tileJ;
	public GameObject tileK;
	public GameObject tileL;
	public GameObject tileM;
	public GameObject tileN;
	public GameObject tileO;
	public GameObject tileP;
	public GameObject tileQ;
	public GameObject tileR;
	public GameObject tileS;
	public GameObject tileT;
	public GameObject tileU;
	public GameObject tileV;
	public GameObject tileW;
	public GameObject tileX;
	public GameObject tileY;
	public GameObject tileZ;
	public GameObject tileSpace;

	public GameObject[] letter_tiles;

	public string prompt = "this is a test";

	//private float tileSize = 1.02F;

	void Start() {
		letter_tiles = new GameObject[26]{tileA, tileB, tileC, tileD, tileE, tileF, tileG, tileH, tileI, tileJ, tileK, tileL, tileM,
			tileN, tileO, tileP, tileQ, tileR, tileS, tileT, tileU, tileV, tileW, tileX, tileY, tileZ};
		displayPrompt (prompt);
	}

	//********* PROMPT *********//

	public GameObject getTile (char letter) {

		GameObject this_tile = null;

		switch (letter) {
		case('a'):
			this_tile = letter_tiles [0];
			break;
		case('b'):
			this_tile = letter_tiles [1];
			break;
		case('c'):
			this_tile = letter_tiles [2];
			break;
		case('d'):
			this_tile = letter_tiles [3];
			break;
		case('e'):
			this_tile = letter_tiles [4];
			break;
		case('f'):
			this_tile = letter_tiles [5];
			break;
		case('g'):
			this_tile = letter_tiles [6];
			break;
		case('h'):
			this_tile = letter_tiles [7];
			break;
		case('i'):
			this_tile = letter_tiles [8];
			break;
		case('j'):
			this_tile = letter_tiles [9];
			break;
		case('k'):
			this_tile = letter_tiles [10];
			break;
		case('l'):
			this_tile = letter_tiles [11];
			break;
		case('m'):
			this_tile = letter_tiles [12];
			break;
		case('n'):
			this_tile = letter_tiles [13];
			break;
		case('o'):
			this_tile = letter_tiles [14];
			break;
		case('p'):
			this_tile = letter_tiles [15];
			break;
		case('q'):
			this_tile = letter_tiles [16];
			break;
		case('r'):
			this_tile = letter_tiles [17];
			break;
		case('s'):
			this_tile = letter_tiles [18];
			break;
		case('t'):
			this_tile = letter_tiles [19];
			break;
		case('u'):
			this_tile = letter_tiles [20];
			break;
		case('v'):
			this_tile = letter_tiles [21];
			break;
		case('w'):
			this_tile = letter_tiles [22];
			break;
		case('x'):
			this_tile = letter_tiles [23];
			break;
		case('y'):
			this_tile = letter_tiles [24];
			break;
		case('z'):
			this_tile = letter_tiles [25];
			break;
		default:
			break;
		}
		return this_tile;
	}

	//place prompt in scene
	public void displayPrompt(string prompt) {

		for (int i = 0; i < prompt.Length; i++) {

			if (getTile(prompt[i]) == null) {
				GameObject tilePrompt = tileSpace;
				tilePrompt = (GameObject)Instantiate(tilePrompt);
				tilePrompt.transform.SetParent(this.transform);

			} else {

				GameObject tilePrompt = getTile(prompt[i]);
				tilePrompt = (GameObject)Instantiate(tilePrompt);
				tilePrompt.transform.SetParent(this.transform);

			}
		}
	}

	public void destroyTiles() {
		for (int i = 0; i < this.transform.childCount; i++) {
			Destroy(this.transform.GetChild(i).gameObject);
		}
		displayPrompt(prompt);
	}
}
