using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	public Text text;
	public Text tries;
	int max;
	int min;
	int guess;

	int maxGuesses = 10;

	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		text.text = "" + guess;
		tries.text = "" + maxGuesses;

		max = max + 1;
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}

	void NextGuess () {
		if (--maxGuesses == 0) {
			Application.LoadLevel("Win");
		}
		guess = (max + min) / 2;
		text.text = "" + guess;
		tries.text = "" + maxGuesses;
	}
}
