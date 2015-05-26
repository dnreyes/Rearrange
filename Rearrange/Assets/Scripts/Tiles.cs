using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tiles : MonoBehaviour {

	public Tile tileA;
	public Tile tileB;
	public Tile tileC;
	public Tile tileD;
	public Tile tileE;
	public Tile tileF;
	public Tile tileG;
	public Tile tileH;
	public Tile tileI;
	public Tile tileJ;
	public Tile tileK;
	public Tile tileL;
	public Tile tileM;
	public Tile tileN;
	public Tile tileO;
	public Tile tileP;
	public Tile tileQ;
	public Tile tileR;
	public Tile tileS;
	public Tile tileT;
	public Tile tileU;
	public Tile tileV;
	public Tile tileW;
	public Tile tileX;
	public Tile tileY;
	public Tile tileZ;
	
	public Tile[] letter_tiles;

	public Camera gameCamera;

	void Start() {
		letter_tiles = new Tile[26]{tileA, tileB, tileC, tileD, tileE, tileF, tileG, tileH, tileI, tileJ, tileK, tileL, tileM,
			tileN, tileO, tileP, tileQ, tileR, tileS, tileT, tileU, tileV, tileW, tileX, tileY, tileZ};
	}

	public Tile getTile (char letter) {

		for (int i = 0; i < letter_tiles.Length; i++) {
			if (letter_tiles [i].tilename == letter) {
				return letter_tiles [i];
			}
		}
		return null;
	}

	//place prompt in scene
	void displayPrompt(int promptsize, string prompt) {
		Tiles tiles = GetComponent<Tiles>();
		int place = promptsize;
		int border = 20;
		int xPos = 20;
		int yPos = 20;
		int width = gameCamera.pixelWidth - border;
		
		//if the prompt can fit in one line
		if (width >= place) {
			xPos = (width - place) / 2;
		}
		
		//if the prompt is longer that width than create a new line
				for (int i = 0; i < prompt.Length; i++) {
					//go through prompt and place them in the scene
					if (tiles.getTile(prompt[i]) == null) {
						xPos += 2; //add a space
						if (xPos > width) {
							place -= width;
							xPos = (width - place)/2;
							yPos += 6;
						}
					} else {
						GameObject tilePrompt = tiles.getTile(prompt[i]);
						tilePrompt = GameObject.Instantiate (tilePrompt, new Vector3 (xPos, yPos, 0), Quaternion.identity) 
							as GameObject;
						xPos += 5;
						if (xPos > width) {
							place -= width;
							xPos = (width - place)/2;
							yPos += 6;
						}
					}
				}
	}


}
