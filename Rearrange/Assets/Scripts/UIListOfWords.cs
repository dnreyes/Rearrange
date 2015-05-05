using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;

public class UIListOfWords: MonoBehaviour {
	
	public InputField answer;
	List<string> used_words;
	public GameObject wordsLvl;
	public GameObject wordsGame;
	public Button close1;
	public Button close2;
	bool uiOpen = false;

	//animator reference
	private Animator anim_lvl;
	private Animator anim_game;


	bool checkWord() {
		//if (answer.text is in text file) {
		//	add to used_words
		//  return true;
		//}
		return false;
	}

	void Start() {
		//unpause the game on start
		Time.timeScale = 1;
		//get the animator component
		anim_lvl = wordsLvl.GetComponent<Animator>();
		anim_game = wordsGame.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		anim_lvl.enabled = false;
		anim_game.enabled = false;
	}

	void onMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			print("here");
			openUI ();
		}
	}
	

	void openUI() {
		//enable the animator component
		anim_lvl.enabled = true;
		anim_game.enabled = true;
		//play the Slidein animation
		anim_lvl.Play("UI_slideIn");
		anim_game.Play("UI_slideIn2");
		//freeze the timescale
		Time.timeScale = 0;
		uiOpen = true;
	}

	void closeUI() {
		//play the SlideOut animation
		anim_lvl.Play("UI_slideOut");
		anim_game.Play("UI_slideOut2");
		//set back the time scale to normal time scale
		Time.timeScale = 1;
		uiOpen = false;
	}

	//button for level words
	//for each valid solution place the word in used_words;
	//display the used words
}
