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
	
	public GameObject[] letter_tiles;

	public string test = "this is a test";

	public Camera gameCamera;

	private float tileSize = 1.02F;

	void Start() {
		letter_tiles = new GameObject[26]{tileA, tileB, tileC, tileD, tileE, tileF, tileG, tileH, tileI, tileJ, tileK, tileL, tileM,
			tileN, tileO, tileP, tileQ, tileR, tileS, tileT, tileU, tileV, tileW, tileX, tileY, tileZ};
		displayPrompt (test);
	}

	//********* PROMPT *********//
	
	//calculates the prompt size to fit onto the camera/canvas
	float calPromptSize(string prompt) {
		float length = 0F;
		
		for (int i = 0; i < prompt.Length; i++) {
			if (prompt [i] != ' ') {
				length += 1.02F;//approx size of tile
			} else {
				length += 0.5F;//approx size of space inbetween words
			}
		}
		return length;
	}

	float calNewLine(string prompt) {
		//calculate if the prompt is longer than the width of the screen
		//check if the newline will cut into the words
		//calculate new prompt length withough cutting into the word
		return 0;
	}

	public GameObject getTile (char letter) {
		GameObject this_tile = null;
//		for (int i = 0; i < letter_tiles.Length; i++) {
//			if (letter_tiles [i].tilename == letter) {
//				return letter_tiles [i];
//			}
//		}
//		return null;
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
		float place = calPromptSize(prompt);
		print (place);
		float border = 0.1F;
		float xPos = 0F;
		float yPos = 4F;
		float width = 5/*600*/-(border*2);


		//if the prompt can fit in one line
		if (width >= place) {
			xPos = ((width - place) / 2);
		} else {
			place -= width;
			xPos = (width - place) / 2;
			yPos -= tileSize;
		}
		
		//if the prompt is longer that width than create a new line
		for (int i = 0; i < prompt.Length; i++) {
		//go through prompt and place them in the scene

			if (getTile(prompt[i]) == null) {
				xPos += 0.2F; //add a space
				if (xPos > width) {
					place -= (xPos + (tileSize/2));
					xPos = (width - place)/2;
					yPos -= tileSize;
				}
			} else {
				GameObject tilePrompt = getTile(prompt[i]);
				tilePrompt = GameObject.Instantiate (tilePrompt, new Vector3 (xPos, yPos, 0), Quaternion.identity) 
					as GameObject;
				xPos += tileSize;
				if (xPos > width) {
					place -= (xPos + (tileSize/2));
					xPos = (width - place)/2;
					yPos -= tileSize;
				}
			}
		}
	}
}
